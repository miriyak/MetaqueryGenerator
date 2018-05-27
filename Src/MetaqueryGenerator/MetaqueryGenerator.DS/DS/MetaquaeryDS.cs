using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MetaqueryGenerator.Common;

namespace MetaqueryGenerator.DS
{
    public static class MetaqueryDS
    {
        public static void Create(TblMetaquery tblMetaquery)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                context.TblMetaqueries.Add(tblMetaquery);
                context.MarkAsCreated(tblMetaquery);
                context.SaveChanges();
            }
        }

		public static TblMetaquery GetByID(int id)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
                    .TblMetaqueries
					.Include(x => x.TblDatabaseManagement)
					.FirstOrDefault(x => x.Id == id)
					;
			}
		}
		public static List<VMetaquery> GetMetaqueriesByID(int dbID)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.VMetaqueries
					.Where(x => x.FkDatabaseId == dbID)
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
					.Where(x => !x.IsExpanded 
								&& ( x.TblMetaqueriesResults.Any() || x.FkResult.HasValue )
								&& x.Arity < x.TblDatabaseManagement.MaxArity)
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
                tblMetaquery.FkStatusId = (int)(newStatus == StatusMQ.ExpandedAndDone ? StatusMQ.Done : newStatus );

                if (newStatus == StatusMQ.WaitingToSolver)
                    tblMetaquery.StartTime = DateTime.Now;
                if (newStatus == StatusMQ.Done || newStatus == StatusMQ.ExpandedAndDone)
                    tblMetaquery.FinishTime = DateTime.Now;
				if (newStatus == StatusMQ.Expanded || newStatus == StatusMQ.ExpandedAndDone)
					tblMetaquery.IsExpanded = true;

				tblMetaquery.TblDatabaseManagement = null;
				context.TblMetaqueries.Attach(tblMetaquery);
                //context.Entry(tblMetaquery).State = System.Data.Entity.EntityState.Modified;
                context.MarkAsModified(tblMetaquery);
                context.SaveChanges();
            }
        }
    }
}
