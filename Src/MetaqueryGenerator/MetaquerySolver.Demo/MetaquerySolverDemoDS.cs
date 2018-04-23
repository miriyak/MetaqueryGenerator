using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MetaqueryGenerator.Common;
using MetaquerySolver.Demo;

namespace MetaquerySolver.Demo
{
    public static class MetaquerySolverDemoDS
	{
        public static void Create(ResultDemoMq tblResultDemoMq)
        {
            using (MQSolverDemoContext context = new MQSolverDemoContext())
            {
                context.ResultDemoMqs.Add(tblResultDemoMq);

                context.SaveChanges();
            }
        }

        public static List<ResultDemoMq> GetResultDemoMq(string metaquery)
        {
            using (MQSolverDemoContext context = new MQSolverDemoContext())
            {
                return context
                    .ResultDemoMqs
                    .Where(x => x.Metaquery == metaquery)
                    .ToList();
            }
        }
       
    }
}
