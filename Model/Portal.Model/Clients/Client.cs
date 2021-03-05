using Portal.Model.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model.Clients
{
    public class Client : BaseEntityModel
    {
        private string _clientName;

        public bool Enable { get; set; }
        public string ClientId { get; private set; }
        public string ProtocolType { get; set; } = Protocols.OpenIdConnect;
        public string Description { get; set; }
        public string LogoClientUri { get; set; }

        public string ClientName 
        {
            get => _clientName;
            set
            {
                _clientName = value;
                ClientId = _clientName.ToLower().Replace(" ", ".");
            } 
        }

        public int AcessTokenLifetime { get; set; } = TokenDefault.AcessTokenLifetime;
        public int TokenLifetime { get; set; } = TokenDefault.TokenLifetime;

        public List<ClientScope> AcceptScope { get; set; }
    }
}
