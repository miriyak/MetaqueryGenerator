using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public interface IMQResultMessage
    {
    }
    public class MQResultMessage : IMQResultMessage
    {
        public int ID;
        public bool Result;
    }
    public class MQAssignmentResultMessage : IMQResultMessage
    {
        public int ID;
        public float SupportValue { get; set; }
        public float ConfidenceValue  { get; set; }
        public string Assignment { get; set; }

    }
}
