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

        public int Level { get { return Variables.Count; } }

        public Relation()
        {
            Variables = new List<int>();
        }
        public Relation(string strRelation)
            : this()
        {
            int startIndex = strRelation.IndexOf("(") + 1;
            int endIndex = strRelation.IndexOf(")");
            int length = endIndex - startIndex ;
            string strIndexes = strRelation.Substring(startIndex, length);
            List<string> list = new List<string>();
            list.AddRange(strIndexes.Split(','));
            this.Variables.AddRange(list.Select(x => Int32.Parse(x)));
            

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
}
