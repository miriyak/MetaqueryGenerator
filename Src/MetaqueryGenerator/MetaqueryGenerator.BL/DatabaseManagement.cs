using MetaqueryGenerator.Common;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaqueryGenerator.BL
{
	public class DatabaseManagement
	{

		private TblDatabaseManagement Create(TblDatabaseManagement tblDatabaseManagement)
		{
			DatabaseManagementsDS.Create(tblDatabaseManagement);

			MQGeneratorMail.SendDBInitializedMail(tblDatabaseManagement);

			return tblDatabaseManagement;
		}
		public bool Create(string dbName,
							string connectionString,
							decimal supportThreshold,
							decimal confidenceThreshold,
							int maxArity
							)
		{
			int maxVariableInRelation = 0;
			ProcessingModelDS modelDS = new ProcessingModelDS(connectionString);
			int demoDbMaxCol = 0;
			int.TryParse(ConfigurationManager.AppSettings["DemoDbMaxCol"], out demoDbMaxCol);

			if (demoDbMaxCol > 0)
				maxVariableInRelation = demoDbMaxCol;
			else
				maxVariableInRelation = modelDS.GetMaxVariablesInRelation();

			TblDatabaseManagement tblDatabaseManagement = new TblDatabaseManagement()
			{
				DbName = dbName,
				ConnectionString = connectionString,
				SupportThreshold = supportThreshold,
				ConfidenceThreshold = confidenceThreshold,
				MaxArity = maxArity,
				FkStatusId = (int)StatusMQ.Received,
				MaxVariablesInRelation = maxVariableInRelation,
				ForExperiment = false
			};
			Create(tblDatabaseManagement);
			return true;
		}


		public TblDatabaseManagement CreateForExperiment(string dbName,
							int maxArity,
							int maxVariableInRelation,
							int supportProbability,
							int confidenceProbability
							)
		{
			TblDatabaseManagement tblDatabaseManagement = new TblDatabaseManagement()
			{
				DbName = dbName,
				ConnectionString = "FOR_Experiment",
				SupportThreshold = 0,
				ConfidenceThreshold = 0,
				MaxArity = maxArity,
				FkStatusId = (int)StatusMQ.Received,
				MaxVariablesInRelation = maxVariableInRelation,
				ForExperiment = true,
				SupportProbability = supportProbability,
				ConfidenceProbability = confidenceProbability
			};
			return Create(tblDatabaseManagement);
		}


	}
}
