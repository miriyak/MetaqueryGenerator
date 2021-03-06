﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQFactory;
using System.Configuration;
using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using MetaqueryGenerator.DS;
using MetaqueryGenerator.Common.Exceptions;

namespace MetaqueryGenerator.BL
{
	public class MQGeneratorConsumer
	{
		private RabbitConsumer<string> consumer;
		public void StartRunConsumer()
		{
			string queueToMQSolverName = ConfigurationManager.AppSettings["QueueToMQGeneratorName"];
			consumer = new RabbitConsumer<string>(queueToMQSolverName);
			consumer.DequeueMessageDel = OnGetMessageFromSolver;
			consumer.ProcessMessages();
		}
		public bool IsRunConsumer()
		{
			return consumer != null;
		}
		public void StopConsumer()
		{
			consumer.StopConsume();
		}
		public static void OnGetMessageFromSolver(string strMessage)
		{

			MQMessage message = null;
			if(strMessage.Contains("Result")) //strMessage is MQResultMessage
				message = JsonConvert.DeserializeObject<MQResultMessage>(strMessage);
			else //strMessage is MQAssignmentResultMessage
				message = JsonConvert.DeserializeObject<MQAssignmentResultMessage>(strMessage);

			int metaqueryID = message.ID;
			TblMetaquery tblMetaquery = MetaqueryDS.GetByID(metaqueryID);
			try
			{
				if (tblMetaquery == null)
					throw new UnknownMetaqueryException(string.Format("There is an unknown metaquery id sent from solver. message id: {0}. MQ Solver message :", metaqueryID, message.ToString()));

				if (message is MQResultMessage)
				{
					MQResultMessage resultMessage = message as MQResultMessage;
					tblMetaquery.FkResult = (int)resultMessage.Result;
					StatusMQ statusMQ = (tblMetaquery.IsExpanded || tblMetaquery.Arity == tblMetaquery.TblDatabaseManagement.MaxArity ? StatusMQ.Done : StatusMQ.WaitingToExpand);
					MetaqueryDS.UpdateStatus(tblMetaquery, statusMQ);
					bool execSendMail = bool.Parse(ConfigurationManager.AppSettings["ExecSendMail"]);
					if (execSendMail)
						MQGeneratorMail.SendResultMail(tblMetaquery);

					if (MQGenerator.IsAutoRunJobs)
					{
						if (statusMQ == StatusMQ.WaitingToExpand)
							MQGenerator.StartExpandMQProcess();
						else if (statusMQ == StatusMQ.Done)
							MQGenerator.StartIncreaseDBArity();
					}
				}
				else if (message is MQAssignmentResultMessage)
				{
					MQAssignmentResultMessage assignmentResultMessage = message as MQAssignmentResultMessage;
					TblMetaqueriesResult tblMetaqueriesResult = new TblMetaqueriesResult()
					{
						FkMetaqueryId = metaqueryID,
						Assignment = assignmentResultMessage.Assignment,
						ConfidenceValue = assignmentResultMessage.ConfidenceValue,
						SupportValue = assignmentResultMessage.SupportValue
					};
					MetaqueryResultDS.Create(tblMetaqueriesResult);

					bool execSendMail = bool.Parse(ConfigurationManager.AppSettings["ExecSendMail"]);
					if (execSendMail)
						MQGeneratorMail.SendAssignmentMail(tblMetaqueriesResult, tblMetaquery.Metaquery);
					if (MQGenerator.IsAutoRunJobs && !tblMetaquery.IsExpanded)
						MQGenerator.StartExpandMQProcess();

				}
				else
					throw new UnknownMetaqueryException("There is an unknown metaquery sent from solver. MQ Solver message :" + message.ToString());
			}
			catch(Exception ex)
			{
				MQGeneratorMail.SendExceptionMail(ex);

			}
		}
	}
}
