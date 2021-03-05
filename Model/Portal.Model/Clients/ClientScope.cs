using System;

namespace Portal.Model.Clients
{
    public class ClientScope : BaseEntityModel
    {
        public string ScopeLabel { get; set; }
        public Guid IdClient { get; set; }

        public Client Client { get; set; }
    }
}