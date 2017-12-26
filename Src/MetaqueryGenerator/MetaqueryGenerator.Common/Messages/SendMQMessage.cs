using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public class SendMQMessage
    {
        public int ID { get; set; }
        public float SupportThreshold { get; set; }
        public float ConfidenceThreshold { get; set; }
        public int[] Head { get; set; }
        public List<List<int>> Body { get; set; }
        
        /*
         o	המידע שנשלח ל – MQ Solver
	ID – מספר פנימי במערכת MQ Generator
	Support (ערך הסף של support ) במבנה 0.xx 
	Confidence (ערך הסף של Confidence) במבנה 0.xx 
	Head (מערך של מספרי המשתנים המרכיבים את ראש השאילתה) 
{1,3}
	Body (מערך דו מימדי של מספרי המשתנים המרכיבים את כל היחסים בגוף השאילתה) במבנה: 
{{1,2,3},{2,3},{3}}

 */
    }
}
