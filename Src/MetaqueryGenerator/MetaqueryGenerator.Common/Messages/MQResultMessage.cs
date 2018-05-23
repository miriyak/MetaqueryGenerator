using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public class MQMessage
    {
		public int ID;
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
	public class MQResultMessage : MQMessage
	{
        public ResultMQ Result;

	}
    public class MQAssignmentResultMessage : MQMessage
	{
        public decimal SupportValue { get; set; }
        public decimal ConfidenceValue  { get; set; }
        public string Assignment { get; set; }
	}
}
