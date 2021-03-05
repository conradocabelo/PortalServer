using Microsoft.EntityFrameworkCore;
using Portal.Model;
using Portal.Model.Clients;


namespace Portal.InfraEstructure.Entity.Context.Interfaces
{
    public interface IPortalContext: IDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientScope> ClientScopes { get; set; }
        public DbSet<CorsOrigin> CorsOrigins { get; set; }
        public DbSet<RedirectLogout> RedirectLogouts { get; set; }
        public DbSet<RedirectUri> RedirectUris { get; set; }
        public DbSet<WebAppClient> WebAppClients { get; set; }
    }
}
