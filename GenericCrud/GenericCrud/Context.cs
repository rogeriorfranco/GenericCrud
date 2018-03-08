using System;
using System.Data.Entity;

namespace GenericCrud
{
    public class Context : DbContext
    {
        public Context()
          : base("connectionString")
        {
        }

       // public DbSet<objectModel> objectModel { get; set; }

        public class MyConfiguration : DbConfiguration
        {
            public MyConfiguration()
            {
                this.SetProviderServices(System.Data.Entity.SqlServer.SqlProviderServices.ProviderInvariantName, System.Data.Entity.SqlServer.SqlProviderServices.Instance);
            }
        }

    }
}
