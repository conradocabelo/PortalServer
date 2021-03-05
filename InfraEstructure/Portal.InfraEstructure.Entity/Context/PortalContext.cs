using Microsoft.EntityFrameworkCore;
using Portal.InfraEstructure.Entity.Context.Interfaces;
using Portal.Model;
using Portal.Model.Clients;
using System.Diagnostics.CodeAnalysis;

namespace Portal.InfraEstructure.Entity.Context
{
    public class PortalContext : DbContext, IPortalContext
    {
        public PortalContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientScope> ClientScopes { get; set; }
        public DbSet<CorsOrigin> CorsOrigins { get; set; }
        public DbSet<RedirectLogout> RedirectLogouts { get; set; }
        public DbSet<RedirectUri> RedirectUris { get; set; }
        public DbSet<WebAppClient> WebAppClients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
