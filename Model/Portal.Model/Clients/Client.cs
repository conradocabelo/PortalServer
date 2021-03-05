using Portal.Model.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model.Clients
{
    public class Client : BaseEntityModel
    {
        public bool Enable { get; set; }
        public string ClientId { get; set; }
        public string ProtocolType { get; set; } = Protocols.OpenIdConnect;
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string LogoClientUri { get; set; }

        public int AcessTokenLifetime { get; set; } = TokenDefault.AcessTokenLifetime;
        public int TokenLifetime { get; set; } = TokenDefault.TokenLifetime;

        public List<ClientScope> AcceptScope { get; set; }
    }
}
