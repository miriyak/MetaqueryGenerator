using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public class Relation
    {
        public const string VariableChar="X";
        private List<int> variables;
        public int VariablesCount { get { return variables.Count(); } }

        public int Level { get { return variables.Count; } }

        public Relation()
        {
            variables = new List<int>();
        }
        
        public void AddVariable(int index)
        {
            variables.Add(index);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var variable in variables)
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
            return "R0" + Head.ToString() + "<-" + Body.ToString();
        }

    }
}
