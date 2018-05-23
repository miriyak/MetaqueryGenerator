using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MetaqueryGenerator.Common;

namespace MetaqueryGenerator.DS
{
    public static class MetaqueryResultDS
	{
        public static void Create(TblMetaqueriesResult tblMetaqueryResult)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                context.TblMetaqueriesResults.Add(tblMetaqueryResult);
                context.MarkAsCreated(tblMetaqueryResult);
                context.SaveChanges();
            }
        }
		public static List<VMetaqueriesResult> GetMetaqueriesResultByID(int metaqueryID)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.VMetaqueriesResults
					.Where(x => x.FkMetaqueryId == metaqueryID)
					.ToList();
			}
		}
		public static List<TblMetaquery> GetMQForExpand()
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                return context
                    .TblMetaqueries
                    .Include(x => x.TblDatabaseManagement)
                    .Where(x => x.HasResult.HasValue /*&& x.HasResult.Value == true && !x.IsExpanded*/)
                    .ToList();
            }
        }
        public static List<TblMetaquery> GetMQForSendToSolver()
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                //mq send to solver if the arity is the current arity processed, and the status is received
                return context
                    .TblMetaqueries
                    .Include(x => x.TblDatabaseManagement)
                    .Where(x => x.FkStatusId == (int)StatusMQ.Received && x.Arity == x.TblDatabaseManagement.CurrentArity)
                    .ToList();
            }
        }
        public static void UpdateStatus(TblMetaquery tblMetaquery, StatusMQ newStatus)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                tblMetaquery.FkStatusId = (int)newStatus;
                if (newStatus == StatusMQ.WaitingToSolver)
                    tblMetaquery.StartTime = DateTime.Now;
                if (newStatus == StatusMQ.Done)
                    tblMetaquery.FinishTime = DateTime.Now;

                context.TblMetaqueries.Attach(tblMetaquery);
                //context.Entry(tblMetaquery).State = System.Data.Entity.EntityState.Modified;
                context.MarkAsModified(tblMetaquery);
                context.SaveChanges();
            }
        }
    }
}
