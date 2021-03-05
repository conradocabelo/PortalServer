using Portal.InfraEstructure.Entity.Context.Interfaces;
using Portal.Model.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.InfraEstructure.Repository.Clients
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(IPortalContext portalAdminContext) : base(portalAdminContext)
        {
        }
    }
}
