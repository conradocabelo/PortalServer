using Portal.InfraEstructure.Repository;
using Portal.InfraEstructure.Repository.Interfaces;
using Xunit;

namespace Portal.Unit.Test.Factories
{
    public class ContextFixture: IClassFixture<ContextFactory>
    {
        public ContextFixture(ContextFactory factory) => ContextFactory = factory;

        public ContextFactory ContextFactory { get; private set; }

        public IUnitOfWork unitOfWork => new UnitOfWork(ContextFactory.PortalContext);
    }
}
