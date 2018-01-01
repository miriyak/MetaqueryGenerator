using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.DS
{
    public class ProcessingModelDS
    {
        public string ConnectionString { get; set; }

        public ProcessingModelDS(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public int GetRelationsCount()
        {
            using (ProcessingMQEntities context = ProcessingMQEntities.Create(ConnectionString))
            {
                return context.Sys_ColumnsTypes.Select(x => x.TableName).Distinct().Count();
            }
        }

        public int GetVariablesCount()
        {
            using (ProcessingMQEntities context = ProcessingMQEntities.Create(ConnectionString))
            {
                return context.Sys_ColumnsTypes.Select(x=> x.Type).Distinct().Count();
            }

            //ProcessingMQModel a;
            //SysDefineTableColumn a;
        }
        public int GetMaxVariablesInRelation()
        {
            return GetRelationsVarCount().First();
            //todo
            /*using (ProcessingMQEntities context = new ProcessingMQEntities())
            {
                return context.SysDefineTableColumns
                    .GroupBy(x => x.TableName)
                   .Select(g => new { name = g.Key, count = g.Count() })
                   .Max(x=> x.count);

                //return context.SysDefineTableColumns.Select(x => x.TableName).Count(;
            }*/
        }
        public List<int> GetRelationsVarCount()
        {
            using (ProcessingMQEntities context = ProcessingMQEntities.Create(ConnectionString))
            {
                return context.Sys_ColumnsTypes
                    .GroupBy(x => x.TableName)
                   .Select(g => g.Count())
                   .OrderByDescending(i => i)
                   .ToList<int>();

                //return context.SysDefineTableColumns.Select(x => x.TableName).Count(;
            }
        }
    }
}
