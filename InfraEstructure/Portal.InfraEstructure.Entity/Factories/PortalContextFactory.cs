using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Portal.InfraEstructure.Entity.Context;
using StGate.InfraEstructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Portal.InfraEstructure.Entity.Factories
{
    public class PortalContextFactory : IDesignTimeDbContextFactory<PortalContext>
    {
        public PortalContext CreateDbContext(string[] args)
        {
            var StringConnection = AppSettings.ConnectionString("InitDb");

            Console.WriteLine("DesignTimeDbContextFactory.Create(string): Connection string: {0}", StringConnection);

            var optionsBuilder = new DbContextOptionsBuilder<PortalContext>();

            optionsBuilder.UseNpgsql(StringConnection,
                sql => sql.MigrationsAssembly(typeof(PortalContextFactory).GetTypeInfo().Assembly.GetName().Name));

            return new PortalContext(optionsBuilder.Options);
        }
    }
}
