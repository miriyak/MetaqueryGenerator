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
        public Relation(int num)
            :this()
        {
            variables.Add(1);
            variables.Add(2);
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
        public List<Relation> List { get; set; }
        public int Level { get { return List.Sum(x=> x.Level); } }

        public RelationsList()
        {
            List = new List<Relation>();
        }
        public RelationsList(int num)
        {
            List = new List<Relation>();
            List.Add(new Relation(2));
            List.Add(new Relation(2));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var relation in List)
                sb.Append(relation.ToString() + ",");
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
            this.Head = new Relation(2);
            this.Body = new RelationsList(2);
        }
        
        public override string ToString()
        {
            return Head.ToString() + "<-" + Body.ToString();
        }

    }
}
