using Portal.InfraEstructure.Entity.Context.Interfaces;
using Portal.InfraEstructure.Repository.Clients;
using Portal.InfraEstructure.Repository.Interfaces;

namespace Portal.InfraEstructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IPortalContext _portalContext;

        public UnitOfWork(IPortalContext portalContext) =>
            _portalContext = portalContext;

        public IClientRepository ClientRepository => new ClientRepository(_portalContext);

        public void SaveChanges() =>
            _portalContext.SaveChanges();
    }
}
