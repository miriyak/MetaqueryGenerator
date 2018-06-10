using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MetaqueryGenerator.Common;

namespace MetaqueryGenerator.DS
{
    public static class ProbabilityExperimentDS
	{
		public static List<TblProbabilityExperiment> GetForExperiment(int countToRun)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
                    .TblProbabilityExperiments
					.Where(x => !x.FkDatabaseId.HasValue)
					.Take(countToRun)
					.ToList()
					;
			}
		}
		public static void Update(TblProbabilityExperiment tblProbabilityExperiment)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				context.TblProbabilityExperiments.Attach(tblProbabilityExperiment);
				context.MarkAsModified(tblProbabilityExperiment);
				context.SaveChanges();
			}
		}

		public static void Create(TblProbabilityExperiment tblProbabilityExperiment)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				context.TblProbabilityExperiments.Add(tblProbabilityExperiment);
				context.MarkAsCreated(tblProbabilityExperiment);
				context.SaveChanges();
			}
		}

		public static void UpdateExperimentResultsAndClear()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				context.UpdateExperimentResultsAndClearDb();
			}
		}
		public static List<int> GetSupportExistsInProbabiltyExperiment()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.TblProbabilityExperiments
					.Where(x => x.ProbabilityIncreaseByArity == null && x.SupportProbability > 0)
					.OrderBy(x => x.SupportProbability)
					.Select(x => x.SupportProbability)
					.Distinct()
					.ToList();
			}

		}
		public static List<int> GetConfidenceExistsInProbabiltyExperiment()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.TblProbabilityExperiments
					.Where(x => x.ProbabilityIncreaseByArity == null && x.ConfidenceProbability > 0)
					.OrderBy(x => x.ConfidenceProbability)
					.Select(x => x.ConfidenceProbability)
					.Distinct()
					.ToList();
			}

		}

		public static List<VProbabilityExperimentResult> GetProbabilityExperimentResult()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.VProbabilityExperimentResults
					//.Where(x => x.MqCount.HasValue && x.SupportProbability == supportProbabilty )
					.ToList()
					;
			}
		}
	}
}
