using MetaqueryGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.BL
{
    public class ProcessMQDetails
    {
        public static int MaxVariablesInRelation { get; set; }
        public static int RelationsCount { get; set; }
        public static int VariablesCount { get; set; }
        static ProcessMQDetails()
        {
            MetaqueryGenerator.DS.ProcessingModelDS modelDS = new MetaqueryGenerator.DS.ProcessingModelDS();
            MaxVariablesInRelation = modelDS.GetMaxVariablesInRelation();
            RelationsCount = modelDS.GetRelationsCount();
            VariablesCount = modelDS.GetVariablesCount();
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
            List<Metaquery> list = VariableExpand(rootMQ);
            foreach(Metaquery q in list)
                Console.WriteLine(q.ToString());
        }
        private List<Metaquery> AddVariable(Relation relation, Metaquery newMQ)
        {
            List<Metaquery> mqList = new List<Metaquery>();
            for (int i = relation.VariablesCount + 1; i < ProcessMQDetails.MaxVariablesInRelation; i++)
            {
                relation.AddVariable(i);
                mqList.Add(newMQ);
            }
            return mqList;
        }
        public List<Metaquery> VariableExpand(Metaquery query)
        {
            List<Metaquery> mqList = new List<Metaquery>();

            Metaquery newMQ = new Metaquery(query);
            mqList.AddRange(AddVariable(query.Head, newMQ));
            foreach(Relation bodyRelation in query.Body.List)
            {
                newMQ = new Metaquery(query);
                mqList.AddRange(AddVariable(bodyRelation, newMQ));
            }
            return mqList;
        }
    }
}
