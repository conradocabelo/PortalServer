using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model.Clients
{
    public class WebAppClient: Client
    {
        public string ClientUri { get; set; }

        public List<RedirectUri> AcceptRedirect { get; set; }
        public List<RedirectLogout> AcceptRedirectLogout { get; set; }
        public List<CorsOrigin> AcceptCorsOrigin { get; set; }
    }
}
