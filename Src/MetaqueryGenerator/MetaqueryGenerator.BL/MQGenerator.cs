using MetaqueryGenerator.Common;
using MetaqueryGenerator.Common.Helpers;
using MetaqueryGenerator.DS;
using Newtonsoft.Json;
using RabbitMQFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.BL
{
    public static class MQGenerator
    {
		//public int SupportThreshold { get; set; }
		//public int ConfidenceThreshold { get; set; }
		public static bool IsAutoRunJobs { get; set; }
		static MQGenerator()
        {
			bool isAutoRunJobs = false;
			bool.TryParse(ConfigurationManager.AppSettings["AutoRunJobs"], out isAutoRunJobs);
			IsAutoRunJobs = isAutoRunJobs;
		}

		public static void StartDBProcess()
        {
            List<TblDatabaseManagement> lstDB = DatabaseManagementsDS.GetDBToWork(StatusDB.Received);
            Metaquery rootMQ = Metaquery.GetRootMQ();
            foreach (TblDatabaseManagement db in lstDB)
            {
                //create first level
                Console.WriteLine("start  : {0}:{1}:{2}:{3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                Console.WriteLine(rootMQ.ToString());
                TblMetaquery tblMetaquery = new TblMetaquery()
                {
                    Arity = rootMQ.Arity,
                    FkDatabaseId = db.Id,
                    FkStatusId = (int)StatusDB.Received,
                    Metaquery = rootMQ.ToString()
                };
                MetaqueryDS.Create(tblMetaquery);
                DatabaseManagementsDS.UpdateStatus(db, StatusDB.InProcess);
            }
			//if at least 1 metaquery created - we can start send it to solver
			if (lstDB.Count > 0 && IsAutoRunJobs)
				StartSendMQToSolver();

		}
		public static int StartSendMQToSolver()
        {
			string queueToMQSolverName = ConfigurationManager.AppSettings["QueueToMQSolverName"];
            List<TblMetaquery> lstMQ = MetaqueryDS.GetMQForSendToSolver();
			RabbitProducer<string> producer = new RabbitProducer<string>(queueToMQSolverName);
			int count = 0;
			foreach (TblMetaquery tblMetaquery in lstMQ)
            {
                TblDatabaseManagement curDB = tblMetaquery.TblDatabaseManagement;
				Metaquery metaquery = new Metaquery(tblMetaquery.Metaquery);

				//שליחה לסולבר
				SendMQMessage message = new SendMQMessage()
				{
					ID = tblMetaquery.Id,
					SupportThreshold = curDB.SupportThreshold,
					ConfidenceThreshold = curDB.ConfidenceThreshold,
					Head = metaquery.Head.Variables,
					Body = metaquery.Body.GetVariables()
				};
				
				string strMessage = message.ToJson();  //JsonConvert.SerializeObject(message);
				producer.SendMessage(strMessage);
				count++;

				//MetaqueryDS.UpdateStatus(tblMetaquery, StatusMQ.WaitingToSolver);
            }
			return count;
		}
		public static void StartExpandMQProcess()
        {
            List<TblMetaquery> lstMQ = MetaqueryDS.GetMQForExpand();
            foreach (TblMetaquery tblMetaquery in lstMQ)
            {
                TblDatabaseManagement curDB = tblMetaquery.TblDatabaseManagement;
                Metaquery metaqueryToExpand = new Metaquery(tblMetaquery.Metaquery);

                //create first level
                //int MaxVariablesInRelation = ProcessMQDetails.MaxVariablesInRelation;
                int maxVariables = curDB.MaxVariablesInRelation;
				ExpandType expandType = ExpandType.All;
				if (tblMetaquery.FkResult == (int)ResultMQ.SupportFailure)
					expandType = ExpandType.NewRelationOnly;
				if (tblMetaquery.FkResult == (int)ResultMQ.ConfidenceFailure)
					expandType = ExpandType.InBodyOnly;

				List<Metaquery> list = metaqueryToExpand.Expand(maxVariables, expandType);
                foreach (Metaquery mq in list)
                {
                    TblMetaquery newTblMetaquery = new TblMetaquery()
                    {
                        Arity = mq.Arity,
                        FkDatabaseId = curDB.Id,
                        FkStatusId = (int)StatusDB.Received,
                        Metaquery = mq.ToString()
                    };
                    MetaqueryDS.Create(newTblMetaquery);
                }
                MetaqueryDS.UpdateStatus(tblMetaquery, StatusMQ.Expanded);
				if(tblMetaquery.FkResult != (int)ResultMQ.HasAnswers)
					MetaqueryDS.UpdateStatus(tblMetaquery, StatusMQ.Done);


				/*
                MetaqueryDS.Create(tblMetaquery);
                DatabaseManagementsDS.UpdateStatus(db, StatusDB.InProcess);*/
			}
			if (IsAutoRunJobs)
				StartIncreaseDBArity();
		}

		public static void StartIncreaseDBArity()
		{
			//Update status of the db that this arity is the last
			List<TblDatabaseManagement> lstFinishDB = DatabaseManagementsDS.GetDBThatFinishedProcess();

			foreach (TblDatabaseManagement db in lstFinishDB)
			{
				DatabaseManagementsDS.UpdateStatus(db, StatusDB.Done);
				MQGeneratorMail.SendDBFinishedMail(db);
			}

			//Increase DB Arity in db that finished calculate the current arity 
			List<TblDatabaseManagement> lstDB = DatabaseManagementsDS.GetDBToIncreaseArity();
			foreach (TblDatabaseManagement db in lstDB)
			{
				db.CurrentArity++;
				DatabaseManagementsDS.Update(db);
				
			}
			if (lstDB.Count > 0 && IsAutoRunJobs)
				StartSendMQToSolver();

		}

		public static void Start()
        {
            StartDBProcess();
            StartSendMQToSolver();
            StartExpandMQProcess();
            /*
            //Console.WriteLine(rootMQ.ToString());
            Console.WriteLine("before 1: {0}:{1}:{2}:{3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            int MaxVariablesInRelation = ProcessMQDetails.MaxVariablesInRelation;
            List<Metaquery> list = rootMQ.Expand(MaxVariablesInRelation);
            Console.WriteLine(" after 1: {0}:{1}:{2}:{3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            foreach(Metaquery q in list)
                Console.WriteLine(q.ToString());*/
        }

		public static List<Metaquery> VariableExpand(Metaquery query)
        {
            List<Metaquery> mqList = new List<Metaquery>();

            Metaquery newMQ;
			//mqList.AddRange(AddVariable(query.Head, newMQ));

			//Check the possibility of adding variable to Head Relation
			int maxVariablesInRelation = 5;

			if (query.Head.Arity < maxVariablesInRelation)
            {

                newMQ = query.Clone();
                newMQ.Head.AddVariable(query.Head.Arity + 1);
                mqList.Add(newMQ);
            }
            //List<int> relationsVarCount = ProcessMQDetails.RelationsVarCount;
            //foreach (Relation bodyRelation in query.Body.List)
            for (int i = 0; i< query.Body.Count; i++)
            {
                Relation bodyRelation = query.Body[i];
                if (bodyRelation.Arity < maxVariablesInRelation) //relationsVarCount[i])
				{
                    newMQ = query.Clone();
                    newMQ.Body[i].AddVariable(bodyRelation.Arity + 1);
                    mqList.Add(newMQ);
                }
                //mqList.AddRange(AddVariable(bodyRelation, newMQ));
            }
            return mqList;
        }
    }

	/*public class ProcessMQDetails
    {
        
        //public static int RelationsCount { get; set; }
        //public static int VariablesCount { get; set; }
        //public static int MaxVariablesInRelation { get; set; }
        public static List<int> RelationsVarCount { get; set; }
        
        static ProcessMQDetails()
        {
            string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = TestMQ; Integrated Security = True";
            MetaqueryGenerator.DS.ProcessingModelDS modelDS = new MetaqueryGenerator.DS.ProcessingModelDS(connectionString);
            //RelationsCount = modelDS.GetRelationsCount();
            //VariablesCount = modelDS.GetVariablesCount();
            //MaxVariablesInRelation = modelDS.GetMaxVariablesInRelation();
            RelationsVarCount = modelDS.GetRelationsVarCount();
        }
    }*/
}
