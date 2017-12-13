using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public static class Extentions
    {
        public static T Clone<T>(this T obj) where T : class
        {
            string str = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(str);
        }
        /*public static Metaquery Clone(this Metaquery metaquery)
        {

            string str = JsonConvert.SerializeObject(metaquery);
            return JsonConvert.DeserializeObject<Metaquery>(str);
        }*/
    }

}