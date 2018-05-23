using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using RabbitMQFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaquerySolver.Demo
{
    public class MetaquerySolverDemoRandom : MetaquerySolverDemo
	{
		//public static void SendMQAssignmentResultMessage(RabbitProducer<string> producer, MQAssignmentResultMessage resultMessage)
		//{
		//	string strMessage = resultMessage.ToJson();
		//	producer.SendMessage(strMessage);
		//}

		public override void OnGetMessageFromGenerator(string strMessage)
		{
			string queueToMQGeneratorName = ConfigurationManager.AppSettings["QueueToMQGeneratorName"];
			RabbitProducer<string> producer = new RabbitProducer<string>(queueToMQGeneratorName);

			SendMQMessage message = JsonConvert.DeserializeObject<SendMQMessage>(strMessage);
			Metaquery metaquery = new Metaquery(message);

			List<ResultDemoMq> resultMQList = MetaquerySolverDemoDS.GetResultDemoMq(metaquery.ToString());

			bool hasResult = resultMQList.Count > 0;
			ResultMQ resultMQ = ResultMQ.HasAnswers;
			if (!hasResult)
			{
				Random rnd = new Random();
				int rndNum = rnd.Next(2);
				if (rndNum == 0)
					resultMQ = ResultMQ.ConfidenceFailure;
				else
					resultMQ = ResultMQ.SupportFailure;

			}
			MQResultMessage resultMessage = new MQResultMessage() { ID = message.ID, Result = resultMQ };

			if (hasResult)
			{
				foreach (ResultDemoMq resultDemoMQ in resultMQList)
				{
					MQAssignmentResultMessage assignmentResultMessage = new MQAssignmentResultMessage()
					{
						ID = message.ID,
						Assignment = resultDemoMQ.Assignment,
						ConfidenceValue = resultDemoMQ.ConfidenceValue.Value,
						SupportValue = resultDemoMQ.SupportValue.Value
					};

					SendMQMessageToSolver(producer, assignmentResultMessage);

					//System.Threading.Thread.Sleep(3000);

				}

			}
			SendMQMessageToSolver(producer, resultMessage);

			//System.Threading.Thread.Sleep(3000);

			/*
			 * MQResultMessage resultMessage = new MQResultMessage() { ID = 1, Result = true};

            string strMessage = JsonConvert.SerializeObject(resultMessage);
            string strResultMessageJson = "{\"ID\":1,\"Result\":true}";
            Assert.AreEqual(strMessage, strResultMessageJson);

            MQAssignmentResultMessage assignmentResultMessage = new MQAssignmentResultMessage() { ID = 1,Assignment="Any assignment",ConfidenceValue=0.3f,SupportValue=0.1f };
            strMessage = JsonConvert.SerializeObject(assignmentResultMessage);
            strResultMessageJson = "{\"ID\":1,\"SupportValue\":0.1,\"ConfidenceValue\":0.3,\"Assignment\":\"Any assignment\"}";
*/
			//MessageBox.Show("TestEvent, string: " + result.Metaquery);


		}
	}
}
