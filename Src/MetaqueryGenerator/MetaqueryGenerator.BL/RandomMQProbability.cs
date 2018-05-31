using MetaqueryGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaqueryGenerator.BL
{
	public class RandomMQProbability
	{
		public int SupportProbability { get; set; }
		public int ConfidenceProbability { get; set; }
		public int ProbabilityIncreaseByArity { get; set; }
		public int MQArity { get; set; }

		public RandomMQProbability(int supportProbability, int confidenceProbability, int probabilityIncreaseByArity, int mqArity)
		{
			SupportProbability = supportProbability;
			ConfidenceProbability = confidenceProbability;
			ProbabilityIncreaseByArity = probabilityIncreaseByArity;
			MQArity = mqArity;
		}

		public ResultMQ GetRandomResultMQ()
		{
			ResultMQ resultMQ = ResultMQ.HasAnswers;

			Random rnd = new Random();
			int rndSupport = rnd.Next(100);
			//Probability of  support failure
			if (rndSupport < (SupportProbability + (MQArity - 2 ) * ProbabilityIncreaseByArity ))
				resultMQ = ResultMQ.SupportFailure;
			else
			{
				//Probability of  confidence failure
				int rndConfidence = rnd.Next(100);
				if (rndConfidence < ( ConfidenceProbability + (MQArity - 2) * ProbabilityIncreaseByArity))
					resultMQ = ResultMQ.ConfidenceFailure;
			}
			return resultMQ;
		}

	}
}
