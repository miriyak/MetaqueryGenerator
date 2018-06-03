using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaqueryGenerator.Common;
using System.Data.Entity;
namespace MetaqueryGenerator.DS
{
    public static class DatabaseManagementsDS
    {
        public static void Create(TblDatabaseManagement tblDatabaseManagement)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                context.TblDatabaseManagements.Add(tblDatabaseManagement);
                context.MarkAsCreated(tblDatabaseManagement);
                context.SaveChanges();
            }
        }
		public static List<KeyValue> GetNotForExperiment()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.TblDatabaseManagements
					.Where(x=> x.ForExperiment == false)
					.Select(x => new KeyValue
					{
						Key = x.Id
						,Value = x.DbName
					})
					.ToList();
			}
		}
		public static TblDatabaseManagement Get(int id)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				return context
					.TblDatabaseManagements
					.Include(x => x.TblStatus)
					.FirstOrDefault(x => x.Id == id);
			}
		}
		public static List<TblDatabaseManagement> GetDBToWork(StatusDB statusDB)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                return context.TblDatabaseManagements.Where(x => x.FkStatusId == (int)statusDB).ToList();
            }
        }
		public static List<TblDatabaseManagement> GetDBToIncreaseArity()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				//We need to increase arity when db in process and have all it's metaqueries in the current arity are done/expanded
				return context
					.TblDatabaseManagements
					.Where(
							x => x.FkStatusId == (int)StatusDB.InProcess &&
							!x.TblMetaqueries.Any(
								m => m.Arity == x.CurrentArity && 
								m.FkStatusId != (int)StatusMQ.Done &&
								m.FkStatusId != (int)StatusMQ.Expanded
								)
					)
					.ToList();
			}
		}
		public static List<TblDatabaseManagement> GetDBThatFinishedProcess()
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				//We finished work with db db that in the current arity all the metaqueries has result and the result is false
				/*return context
					.TblDatabaseManagements
					.Where(
							x => x.FkStatusId == (int)StatusDB.InProcess &&
							x.TblMetaqueries.Where(m => m.Arity == x.CurrentArity)
								.All(m => m.HasResult.HasValue && m.HasResult.Value == false)
					)
					.ToList();*/
				return context
				.TblDatabaseManagements
				.Where(
						x => x.FkStatusId == (int)StatusDB.InProcess &&
						x.CurrentArity == x.MaxArity &&
							x.TblMetaqueries.Where(m => m.Arity == x.CurrentArity)
								.All(m => m.FkResult.HasValue)
				)
				.ToList();
			}
		}
		public static void UpdateStatus(TblDatabaseManagement tblDatabaseManagement ,StatusDB newStatus)
        {
            tblDatabaseManagement.FkStatusId = (int)newStatus;
            if(newStatus == StatusDB.InProcess)
            { 
                tblDatabaseManagement.StartTime = DateTime.Now;
                tblDatabaseManagement.CurrentArity = 2;
            }
            if (newStatus == StatusDB.Done)
                tblDatabaseManagement.FinishTime = DateTime.Now;

			Update(tblDatabaseManagement);
        }
		public static void Update(TblDatabaseManagement tblDatabaseManagement)
		{
			using (MetaqueriesContext context = new MetaqueriesContext())
			{
				context.TblDatabaseManagements.Attach(tblDatabaseManagement);
				context.MarkAsModified(tblDatabaseManagement);
				context.SaveChanges();
			}
		}
	}
}
