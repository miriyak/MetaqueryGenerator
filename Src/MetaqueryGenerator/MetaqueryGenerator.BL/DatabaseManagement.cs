using MetaqueryGenerator.Common;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
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
                            decimal confidenceThreshold
                            )
        {
            int maxVariableInRelation = 0;
			ProcessingModelDS modelDS = new ProcessingModelDS(connectionString);
			maxVariableInRelation = modelDS.GetMaxVariablesInRelation();

			TblDatabaseManagement tblDatabaseManagement = new TblDatabaseManagement()
            {
                DbName = dbName,
                ConnectionString = connectionString,
                SupportThreshold = supportThreshold,
                ConfidenceThreshold = confidenceThreshold,
                FkStatusId = (int)StatusMQ.Received,
                MaxVariablesInRelation = maxVariableInRelation
            };
            DatabaseManagementsDS.Create(tblDatabaseManagement);

			MQGeneratorMail.SendDBInitializedMail(tblDatabaseManagement);

			return true;
        }

		
	}
}
