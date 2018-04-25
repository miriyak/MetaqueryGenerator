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
    public class MetaquerySolverDemo
    {
		private RabbitConsumer<string> consumer;
		
		public void RunConsumer(string queueName)
		{
			consumer = new RabbitConsumer<string>(queueName);
			consumer.DequeueMessageDel = OnGetMessageFromGenerator;
			consumer.ProcessMessages();
		}
		public void StopConsume()
		{
			consumer.StopConsume();
		}
		public static void SendMQMessageToSolver(RabbitProducer<string> producer, MQMessage resultMessage)
		{
			string strMessage = resultMessage.ToJson(); 
			producer.SendMessage(strMessage);
		}

		//public static void SendMQAssignmentResultMessage(RabbitProducer<string> producer, MQAssignmentResultMessage resultMessage)
		//{
		//	string strMessage = resultMessage.ToJson();
		//	producer.SendMessage(strMessage);
		//}

		public static void OnGetMessageFromGenerator(string strMessage)
		{
			string queueToMQGeneratorName = ConfigurationManager.AppSettings["QueueToMQGeneratorName"];
			RabbitProducer<string> producer = new RabbitProducer<string>(queueToMQGeneratorName);

			SendMQMessage message = JsonConvert.DeserializeObject<SendMQMessage>(strMessage);
			Metaquery metaquery = new Metaquery(message);

			List<ResultDemoMq> resultMQList = MetaquerySolverDemoDS.GetResultDemoMq(metaquery.ToString());

			bool hasResult = resultMQList.Count > 0;

			MQResultMessage resultMessage = new MQResultMessage() { ID = message.ID, Result = hasResult };

			if (hasResult)
			{
				foreach (ResultDemoMq resultMQ in resultMQList)
				{
					MQAssignmentResultMessage assignmentResultMessage = new MQAssignmentResultMessage()
					{
						ID = message.ID,
						Assignment = resultMQ.Assignment,
						ConfidenceValue = resultMQ.ConfidenceValue.Value,
						SupportValue = resultMQ.SupportValue.Value
					};

					SendMQMessageToSolver(producer, resultMessage);

					System.Threading.Thread.Sleep(3000);

				}

			}
			SendMQMessageToSolver(producer, resultMessage);

			System.Threading.Thread.Sleep(3000);

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
