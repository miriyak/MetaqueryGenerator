using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public interface IMQResultMessage
    {
		string ToJson();

	}
	public class MQResultMessage : IMQResultMessage
    {
        public int ID;
        public bool Result;
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
    public class MQAssignmentResultMessage : IMQResultMessage
    {
        public int ID;
        public decimal SupportValue { get; set; }
        public decimal ConfidenceValue  { get; set; }
        public string Assignment { get; set; }
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this);
		}

	}
}
