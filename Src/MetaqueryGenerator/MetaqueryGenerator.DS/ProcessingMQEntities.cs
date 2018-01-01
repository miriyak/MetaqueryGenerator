using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaqueryGenerator.DS
{
    public partial class ProcessingMQEntities : DbContext
    {
        public ProcessingMQEntities(string nameOrConnectionString)
        : base(nameOrConnectionString)
        {
        }

        public static ProcessingMQEntities Create(string providerConnectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder
            {

                // use your ADO.NET connection string
                ProviderConnectionString = providerConnectionString,

                Provider = "System.Data.SqlClient",

                // Set the Metadata location.
                Metadata = @"res://*/ProcessingMQModel.csdl|res://*/ProcessingMQModel.ssdl|res://*/ProcessingMQModel.msl"
            };
            //string connectionString = @"res://*/ProcessingMQModel.csdl|res://*/ProcessingMQModel.ssdl|res://*/ProcessingMQModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\SQLEXPRESS;initial catalog=DatabaseManagement;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";

            return new ProcessingMQEntities(entityBuilder.ConnectionString);
        }

        
        

    }
}
