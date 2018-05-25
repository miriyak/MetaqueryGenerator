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
                MaxVariablesInRelation = maxVariableInRelation
            };
            DatabaseManagementsDS.Create(tblDatabaseManagement);

			MQGeneratorMail.SendDBInitializedMail(tblDatabaseManagement);

			return true;
        }


		
	}
}
