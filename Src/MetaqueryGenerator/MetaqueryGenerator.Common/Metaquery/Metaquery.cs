using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public class Metaquery 
    {
        public Relation Head { get; set; }
        public RelationsList Body { get; set; }
        public int Level { get { return Head.Level + Body.Level;  } }

        public Metaquery()
        {
            //create blank metaquery by default
            this.Head = new Relation();
            this.Body = new RelationsList();
        }
        public Metaquery(string strMetaqurey)
            :this()
        {
            strMetaqurey = strMetaqurey.Replace("X", "");
            string[] list = strMetaqurey.Split('←');
            if (list.Length != 2)
                return;
            Head = new Relation(list[0]);
            string[] listBody = list[1].Split('&');
            foreach (string strRelation in listBody)
                this.Body.Add(new Relation(strRelation));
            //"R0(1,2)←R1(1,2)&R2(1,2)"
        }

        public List<Metaquery> Expand(/*int maxVariablesInRelation,int relationsVarCount*/)
        {
            List<Metaquery> mqList = new List<Metaquery>();

            //Metaquery newMQ;

            mqList.AddRange(this.ExpandHead());
            /*
            //List<int> relationsVarCount = ProcessMQDetails.RelationsVarCount;
            //foreach (Relation bodyRelation in this.Body.List)
            for (int i = 0; i < this.Body.Count; i++)
            {
                Relation bodyRelation = this.Body[i];
                if (bodyRelation.Level < relationsVarCount[i])
                {
                    newMQ = this.Clone();
                    newMQ.Body[i].AddVariable(bodyRelation.Level + 1);
                    mqList.Add(newMQ);
                }
                //mqList.AddRange(AddVariable(bodyRelation, newMQ));
            }*/
            return mqList;
        }

        public List<Metaquery> ExpandHead()
        {
            List<Metaquery> mqList = new List<Metaquery>();
            Metaquery newMQ;

            //Check the possibility of adding variable to Head Relation
            List<int> allBodyVariables = this.Body.GetAllVariables();
            int maxVariableInBody = allBodyVariables.Max();
            int maxVariableInHead = this.Head.Variables.Max();
            for (int newVar = maxVariableInHead + 1; newVar <= maxVariableInBody; newVar++)
            {
                newMQ = this.Clone();
                newMQ.Head.AddVariable(newVar);
                mqList.Add(newMQ);
            }
            return mqList;
        }
        public static Metaquery GetRootMQ()
        {
            //set Head
            Metaquery metaquery = new Metaquery();
            metaquery.Head.AddVariable(1);

            //set Body
            Relation relation = new Relation();
            relation.AddVariable(1);

            metaquery.Body.Add(relation);

            return metaquery;
        }

        public override string ToString()
        {
            return "R0" + Head.ToString() + "←" + Body.ToString();
        }

    }
}
