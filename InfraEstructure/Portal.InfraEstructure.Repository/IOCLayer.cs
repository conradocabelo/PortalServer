using Microsoft.Extensions.DependencyInjection;
using Portal.InfraEstructure.Repository.Interfaces;

namespace Portal.InfraEstructure.Repository
{
    public static class IOCLayer
    {
        public static IServiceCollection InfraEstructureRepositoryIOC(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
