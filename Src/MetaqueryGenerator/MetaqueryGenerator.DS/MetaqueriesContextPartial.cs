using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaqueryGenerator.DS
{
    public partial class MetaqueriesContext
    {
        public void MarkAsModified<TEntity>(TEntity item, string[] modifiedFields = null) where TEntity : class
        {
            if (modifiedFields == null)
                Entry(item).State = EntityState.Modified;
            else
            {
                Entry(item).State = EntityState.Unchanged;

                Entry(item).Property("LastUpdatedDate").IsModified = true;
                Entry(item).Property("LastUpdatedBy").IsModified = true;

                foreach (string field in modifiedFields)
                    Entry(item).Property(field).IsModified = true;
            }
            SetUpdatedFields(item);
        }

        public void MarkAsCreated<TEntity>(TEntity item) where TEntity : class
        {
            SetUpdatedFields(item);
            SetCreatedFields(item);
        }
        private void SetUpdatedFields<TEntity>(TEntity item) where TEntity : class
        {
            if (Entry(item).CurrentValues.PropertyNames.Contains("LastUpdatedDate"))
                Entry(item).Property("LastUpdatedDate").CurrentValue = DateTime.Now;
            /*
            if (Entry(item).CurrentValues.PropertyNames.Contains("LastUpdatedBy"))
               Entry(item).Property("LastUpdatedBy").CurrentValue = AuthorizationHelper.GetCurrentUserName();
               */

        }

        private void SetCreatedFields<TEntity>(TEntity item) where TEntity : class
        {
            if (Entry(item).CurrentValues.PropertyNames.Contains("CreatedDate"))
                Entry(item).Property("CreatedDate").CurrentValue = DateTime.Now;
            /*
             if (Entry(item).CurrentValues.PropertyNames.Contains("CreatedBy"))
                Entry(item).Property("CreatedBy").CurrentValue = AuthorizationHelper.GetCurrentUserName();
                */

        }

    }
}
