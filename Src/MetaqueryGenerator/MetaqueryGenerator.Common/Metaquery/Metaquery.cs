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
        public int Arity { get { return Head.Arity + Body.Arity;  } }

        /// <summary>
        /// default constructor
        /// </summary>
        public Metaquery()
        {
            //create blank metaquery by default
            this.Head = new Relation();
            this.Body = new RelationsList();
        }
        /// <summary>
        /// constructor that create metaquery by string input
        /// </summary>
        /// <param name="strMetaqurey"></param>
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

		public Metaquery(SendMQMessage mqMessage)
			: this()
		{
			this.Head = new Relation();
			this.Head.Variables.AddRange(mqMessage.Head);

			foreach (List<int> lst in mqMessage.Body)
			{
				Relation relation = new Relation();
				relation.Variables.AddRange(lst);
				this.Body.Add(relation);
			}
		}
		/// <summary>
		/// Expand metaquery -- all types
		/// </summary>
		/// <param name="maxVariablesInRelation">Max of variables in relation - by the db</param>
		/// <returns>List of expanded metaquery</returns>
		public List<Metaquery> Expand(int maxVariablesInRelation)
        {
            List<Metaquery> mqList = new List<Metaquery>();

            mqList.AddRange(this.ExpandBodyVariable(maxVariablesInRelation));
            mqList.AddRange(this.ExpandHead());
            mqList.AddRange(this.ExpandBodyRelation());
            
            return mqList;
        }
        
        public List<Metaquery> ExpandBodyVariable(int maxVariablesInRelation)
        {
            List<Metaquery> mqList = new List<Metaquery>();
            if(this.Body.Last().Variables.Count + 1 < maxVariablesInRelation)
            { 
                Metaquery newMQ;

                //Check the possibility of adding variable to Head Relation
            
                newMQ = this.Clone();
                Relation relation = newMQ.Body.Last();
                relation.AddNextVariable();

                mqList.Add(newMQ);

            }
            return mqList;
        }

        public List<Metaquery> ExpandBodyRelation()
        {
            List<Metaquery> mqList = new List<Metaquery>();
            Metaquery newMQ;

            //Check the possibility of adding variable to Head Relation
            List<int> allBodyVariables = this.Body.GetAllVariables();
            int maxVariableInBody = allBodyVariables.Max();

            for (int newVar = maxVariableInBody; newVar <= maxVariableInBody + 1; newVar++)
            {
                newMQ = this.Clone();
                Relation relation = new Relation();
                relation.AddVariable(newVar);
                newMQ.Body.Add(relation);
                mqList.Add(newMQ);
            }
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
