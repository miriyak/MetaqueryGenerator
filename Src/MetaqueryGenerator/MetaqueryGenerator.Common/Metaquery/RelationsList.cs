using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public class RelationsList : List<Relation>
    {
        public int Arity { get { return this.Sum(x=> x.Arity); } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i< this.Count; i++)
                sb.Append("R" + (i+1)+ this[i].ToString() + "&");
            if(sb.Length > 0)
                sb.Remove(sb.Length-1, 1);

            return sb.ToString();

        }

		public List<List<int>> GetVariables()
		{
			List<List<int>> list = new List<List<int>>();
			for (int i = 0; i < this.Count; i++)
			{
				list.Add(this[i].Variables);
			}
			return list;
		}

		internal List<int> GetAllVariables()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < this.Count; i++)
                for (int j = 0; j < this[i].Variables.Count; j++)
                {
                    int variable = this[i].Variables[j];
                    if (!list.Contains(variable))
                        list.Add(this[i].Variables[j]);
                }
            return list;
        }
    }
}
