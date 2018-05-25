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
		public int SupportProbability { get; set; }
		public int ConfidenceProbability { get; set; }
		public void RunConsumer(string queueName, int supportProbability, int confidenceProbability)
		{
			base.RunConsumer(queueName);

			SupportProbability = supportProbability;
			ConfidenceProbability = confidenceProbability;
		}
		public override void OnGetMessageFromGenerator(string strMessage)
		{
			string queueToMQGeneratorName = ConfigurationManager.AppSettings["QueueToMQGeneratorName"];
			RabbitProducer<string> producer = new RabbitProducer<string>(queueToMQGeneratorName);

			SendMQMessage message = JsonConvert.DeserializeObject<SendMQMessage>(strMessage);
			Metaquery metaquery = new Metaquery(message);

			ResultMQ resultMQ = ResultMQ.HasAnswers;

			// Random the probability of the result
			Random rnd = new Random();
			int rndSupport = rnd.Next(100);
			//Probability of  support failure
			if (rndSupport < SupportProbability)
				resultMQ = ResultMQ.SupportFailure;
			else
			{
				//Probability of  confidence failure
				int rndConfidence = rnd.Next(100);
				if (rndConfidence < ConfidenceProbability)
					resultMQ = ResultMQ.ConfidenceFailure;
			}
			MQResultMessage resultMessage = new MQResultMessage() { ID = message.ID, Result = resultMQ };

			if (resultMQ == ResultMQ.HasAnswers)
			{
				MQAssignmentResultMessage assignmentResultMessage = new MQAssignmentResultMessage()
				{
					ID = message.ID,
					Assignment = "TEST - Assignment",
					ConfidenceValue = 0,
					SupportValue = 0
				};

				SendMQMessageToSolver(producer, assignmentResultMessage);
			}
			SendMQMessageToSolver(producer, resultMessage);

		}
	}
}
