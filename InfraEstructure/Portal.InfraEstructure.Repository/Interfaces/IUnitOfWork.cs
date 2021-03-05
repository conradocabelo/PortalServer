using Portal.InfraEstructure.Entity.Context.Interfaces;
using Portal.InfraEstructure.Repository.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.InfraEstructure.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        public IClientRepository ClientRepository { get; }

        void SaveChanges();
    }
}
