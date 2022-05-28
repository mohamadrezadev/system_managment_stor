using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using BEE;
namespace DAL
{
   public class DB:DbContext
    {
        public DB(): base("name=winapp") {
            var ensureDLLIsCopied =
          System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<moshtari> Moshtaris { get; set; }
        public DbSet<kala> Kalas { get; set; }
        public DbSet<factor> Factors { get; set; }
        public DbSet<account_moshtari> Account_Moshtaris { get; set; }
        public DbSet<user> Users { get; set; }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
        ////        <connectionStrings>
        //  <add name = "winapp" connectionString="Data Source=MOHAMADREZA;Initial Catalog=winapp;Integrated Security=true" providerName="System.Data.SqlClient" />
        //</connectionStrings>
        //  <configSections>
        //  <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
        //  <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
        //  <section name = "entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />

        //</configSections>
    }
}
