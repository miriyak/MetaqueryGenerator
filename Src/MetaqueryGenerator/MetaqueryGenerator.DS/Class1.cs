using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.DS
{
    public class ProcessingModelDS
    {
        public int GetRelationsCount()
        {
            using (ProcessingMQEntities context = new ProcessingMQEntities())
            {
                return context.SysDefineTableColumns.Select(x => x.TableName).Distinct().Count();
            }
            
            //ProcessingMQModel a;
            //SysDefineTableColumn a;
        }

        public int GetVariablesCount()
        {
            using (ProcessingMQEntities context = new ProcessingMQEntities())
            {
                return context.SysDefineTableColumns.Select(x=> x.VariableName).Distinct().Count();
            }

            //ProcessingMQModel a;
            //SysDefineTableColumn a;
        }
        public int GetMaxVariablesInRelation()
        {
            //todo
            using (ProcessingMQEntities context = new ProcessingMQEntities())
            {
                return context.SysDefineTableColumns
                    .GroupBy(x => x.TableName)
                   .Select(g => new { name = g.Key, count = g.Count() })
                   .Max(x=> x.count);

                //return context.SysDefineTableColumns.Select(x => x.TableName).Count(;
            }

            //ProcessingMQModel a;
            //SysDefineTableColumn a;
        }
    }
}
