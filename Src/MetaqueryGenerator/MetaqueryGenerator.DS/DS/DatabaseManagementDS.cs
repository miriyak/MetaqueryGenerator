using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaqueryGenerator.Common;

namespace MetaqueryGenerator.DS
{
    public static class DatabaseManagementsDS
    {
        public static List<TblDatabaseManagement> GetDBToWork()
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                return context.TblDatabaseManagements.Where(x => x.FkStatusId == (int)Common.StatusDB.Received).ToList();
            }
        }

        public static void UpdateStatus(TblDatabaseManagement tblDatabaseManagement ,StatusDB newStatus)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                tblDatabaseManagement.FkStatusId = (int)newStatus;
                if(newStatus == StatusDB.InProcess)
                { 
                    tblDatabaseManagement.StartTime = DateTime.Now;
                    tblDatabaseManagement.CurrentArity = 2;
                }
                if (newStatus == StatusDB.Done)
                    tblDatabaseManagement.FinishTime = DateTime.Now;


                context.TblDatabaseManagements.Attach(tblDatabaseManagement);
                context.Entry(tblDatabaseManagement).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
