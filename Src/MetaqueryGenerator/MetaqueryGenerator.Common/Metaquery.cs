using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public class Relation
    {
        public const string VariableChar="X";
        public List<int> Variables { get; set; }
        public int VariablesCount { get { return Variables.Count(); } }

        public int Level { get { return Variables.Count; } }

        public Relation()
        {
            Variables = new List<int>();
        }
        
        public void AddVariable(int index)
        {
            Variables.Add(index);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var variable in Variables)
                sb.Append(VariableChar +  variable + ",");
            if(sb.Length > 0)
                sb.Remove(sb.Length-1, 1);

            return "(" + sb.ToString() + ")";
        }
    }
    public class RelationsList : List<Relation>
    {
        //public List<Relation> List { get; set; }
        public int Level { get { return this.Sum(x=> x.Level); } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i< this.Count; i++)
                sb.Append("R" + (i+1)+ this[i].ToString() + "&");
            if(sb.Length > 0)
                sb.Remove(sb.Length-1, 1);

            return sb.ToString();

        }

        internal List<int> GetAllVariables()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < this.Count; i++)
                for (int j = 0; j < this.Count; j++)
                {
                    int variable = this[i].Variables[j];
                    if (!list.Contains(variable))
                        list.Add(this[i].Variables[j]);
                }
            return list;
        }
    }
    public class Metaquery 
    {
        public Relation Head { get; set; }
        public RelationsList Body { get; set; }
        public int Level { get { return Head.Level + Body.Level;  } }

        public Metaquery()
        {
            //create root metaquery by default
            this.Head = new Relation();
            this.Body = new RelationsList();
        }
        
        public List<Metaquery> Expand(/*int maxVariablesInRelation,int relationsVarCount*/)
        {
            List<Metaquery> mqList = new List<Metaquery>();

            Metaquery newMQ;

            //Head Expand
            //Check the possibility of adding variable to Head Relation
            List<int> allBodyVariables = this.Body.GetAllVariables();
            int maxVariableInBody = allBodyVariables.Max();
            int maxVariableInHead = this.Head.Variables.Max();
            for (int newVar = maxVariableInHead + 1 ; newVar <= maxVariableInHead; newVar++)
            {
                newMQ = this.Clone();
                newMQ.Head.AddVariable(newVar);
                mqList.Add(newMQ);
            }
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
