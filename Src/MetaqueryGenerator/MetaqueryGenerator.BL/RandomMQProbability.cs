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
		public RandomMQProbability(int supportProbability, int confidenceProbability)
		{
			SupportProbability = supportProbability;
			ConfidenceProbability = confidenceProbability;
		}

		public ResultMQ GetRandomResultMQ()
		{
			ResultMQ resultMQ = ResultMQ.HasAnswers;

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
			return resultMQ;
		}

	}
}
