using System;

namespace Portal.Model.Clients
{
    public class CorsOrigin: BaseEntityModel
    {
        public string Uri { get; set; }
        public Guid IdClient { get; set; }

        public WebAppClient WebAppClient { get; set; }
    }
}