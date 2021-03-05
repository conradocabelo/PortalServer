using Portal.InfraEstructure.Entity.Context.Interfaces;
using Portal.Model.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.InfraEstructure.Repository.Clients
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(IPortalContext portalAdminContext) : base(portalAdminContext)
        {
        }

        public Client FindClintById(string ClientId) => 
            this.Select(t => t.ClientId == ClientId).FirstOrDefault();
    }
}
