using MetaqueryGenerator.Common;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.BL
{
    public class ProcessMQDetails
    {
        
        public static int RelationsCount { get; set; }
        public static int VariablesCount { get; set; }
        public static int MaxVariablesInRelation { get; set; }
        public static List<int> RelationsVarCount { get; set; }
        
        static ProcessMQDetails()
        {
            MetaqueryGenerator.DS.ProcessingModelDS modelDS = new MetaqueryGenerator.DS.ProcessingModelDS();
            RelationsCount = modelDS.GetRelationsCount();
            VariablesCount = modelDS.GetVariablesCount();
            MaxVariablesInRelation = modelDS.GetMaxVariablesInRelation();
            RelationsVarCount = modelDS.GetRelationsVarCount();
        }
    }

public class MQGenerator
    {
        
        public MQGenerator()
        {
            
        }
        public void Expand(Metaquery mq)
        {
            


        }

        public void Start()
        {
            //create first level
            Metaquery rootMQ = new Metaquery();
            Console.WriteLine(rootMQ.ToString());
            Console.WriteLine("before 1: {0}:{1}:{2}:{3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            List<Metaquery> list = VariableExpand(rootMQ);
            Console.WriteLine(" after 1: {0}:{1}:{2}:{3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            foreach(Metaquery q in list)
                Console.WriteLine(q.ToString());
        }

        public List<Metaquery> VariableExpand(Metaquery query)
        {
            List<Metaquery> mqList = new List<Metaquery>();

            Metaquery newMQ;
            //mqList.AddRange(AddVariable(query.Head, newMQ));
            
            //Check the possibility of adding variable to Head Relation
            if (query.Head.Level < ProcessMQDetails.MaxVariablesInRelation)
            {

                newMQ = query.Clone();
                newMQ.Head.AddVariable(query.Head.Level + 1);
                mqList.Add(newMQ);
            }
            List<int> relationsVarCount = ProcessMQDetails.RelationsVarCount;
            //foreach (Relation bodyRelation in query.Body.List)
            for (int i = 0; i< query.Body.List.Count; i++)
            {
                Relation bodyRelation = query.Body.List[i];
                if (bodyRelation.Level < relationsVarCount[i])
                {
                    newMQ = query.Clone();
                    newMQ.Body.List[i].AddVariable(bodyRelation.Level + 1);
                    mqList.Add(newMQ);
                }
                //mqList.AddRange(AddVariable(bodyRelation, newMQ));
            }
            return mqList;
        }
    }
}
