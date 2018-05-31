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

	}
}
