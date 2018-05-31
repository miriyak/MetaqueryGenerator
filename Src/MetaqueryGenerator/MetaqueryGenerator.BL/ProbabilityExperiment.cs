using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaqueryGenerator.BL
{
	public class ProbabilityExperiment
	{
		public static void UpdateProbabiltyExperiment()
		{
			
		}
		public static  void Run()
		{
			UpdateProbabiltyExperiment();
			int experimentCount = 0;
			int.TryParse(ConfigurationManager.AppSettings["ExperimentCount"], out experimentCount);
			bool flag = false;
			List<TblProbabilityExperiment> lst = ProbabilityExperimentDS.GetForExperiment(experimentCount);
			foreach (TblProbabilityExperiment tblExp in lst)
			{
				DatabaseManagement dbManagement = new DatabaseManagement();
				TblDatabaseManagement newDB = dbManagement.CreateForExperiment(
					"exp_" + tblExp.SupportProbability + "_" + tblExp.ConfidenceProbability
					, tblExp.MaxArity
					, tblExp.MaxVariablesInRelation
					, tblExp.SupportProbability
					, tblExp.ConfidenceProbability
					, tblExp.ProbabilityIncreaseByArity
					);
				if(newDB!=null)
				{
					flag = true;
					tblExp.FkDatabaseId = newDB.Id;
					ProbabilityExperimentDS.Update(tblExp);
				}
			}
			if (flag && MQGenerator.IsAutoRunJobs)
				MQGenerator.StartDBProcess();
		}
	}
}
