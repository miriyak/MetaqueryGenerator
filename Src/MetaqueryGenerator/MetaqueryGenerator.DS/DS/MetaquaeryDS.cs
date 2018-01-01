using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MetaqueryGenerator.DS
{
    public static class MetaqueryDS
    {
        public static void Create(TblMetaquery tblMetaquery)
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                context.TblMetaqueries.Attach(tblMetaquery);
                context.SaveChanges();
            }
        }

        public static List<TblMetaquery> GetMQToExpand()
        {
            using (MetaqueriesContext context = new MetaqueriesContext())
            {
                return context
                    .TblMetaqueries
                    .Include(x => x.TblDatabaseManagement)
                    .Where(x => x.HasResult.HasValue && x.HasResult.Value == true && !x.IsExpanded)
                    .ToList();
            }
        }

    }
}
