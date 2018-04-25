using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQFactory;
using System.Configuration;
using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using MetaqueryGenerator.DS;

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

		public void StopConsumer()
		{
			consumer.StopConsume();
		}
		public static void OnGetMessageFromSolver(string strMessage)
		{

			MQMessage message = null;
			try
			{
				message = JsonConvert.DeserializeObject<MQResultMessage>(strMessage);
			}
			catch
			{
				try
				{
					message = JsonConvert.DeserializeObject<MQAssignmentResultMessage>(strMessage);
				}
				catch
				{
				}
			}
			int metaqueryID = message.ID;
			TblMetaquery tblMetaquery = MetaqueryDS.GetByID(metaqueryID);
			if (tblMetaquery == null)
				throw new Exception("There is an unknown metaquery id sent from solver");

			if (message is MQResultMessage)
			{
				MQResultMessage resultMessage = message as MQResultMessage;
				tblMetaquery.HasResult = resultMessage.Result;
				MetaqueryDS.UpdateStatus(tblMetaquery, StatusMQ.Done);

				MQGeneratorMail.SendResultMail(tblMetaquery);

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
				MetaquaeryResultDS.Create(tblMetaqueriesResult);

				MQGeneratorMail.SendAssignmentMail(tblMetaqueriesResult, tblMetaquery.Metaquery);

			}
		}
	}
}
