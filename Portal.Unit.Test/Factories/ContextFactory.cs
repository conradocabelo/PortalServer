using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Portal.InfraEstructure.Entity.Context;
using Portal.InfraEstructure.Entity.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Portal.Unit.Test.Factories
{
    public class ContextFactory : IDisposable
    {
        private readonly DbConnection _dbConnection;
        private readonly PortalContext _portalContext;

        public IPortalContext PortalContext => _portalContext;

        public ContextFactory()
        {
           var ContextOptions = new DbContextOptionsBuilder<PortalContext>()
                                                           .UseSqlite(CreateInMemoryDatabase())
                                                           .Options;

            _dbConnection = RelationalOptionsExtension.Extract(ContextOptions).Connection;
            _portalContext = new PortalContext(ContextOptions);
            
            _portalContext.Database.EnsureCreated();
        }

        private static DbConnection CreateInMemoryDatabase()
        {
            var connection = new SqliteConnection("Filename=:memory:");

            connection.Open();

            return connection;
        }


        public void Dispose()
        {
            _dbConnection.Dispose();
            _portalContext.Dispose();
        }
    }
}
