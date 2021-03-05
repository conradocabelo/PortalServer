using Microsoft.Extensions.DependencyInjection;
using Portal.InfraEstructure.Entity.Context;
using Portal.InfraEstructure.Entity.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.InfraEstructure.Entity
{
    public static class IOCLayer
    {
        public static IServiceCollection InfraEstructureEntityIOC(this IServiceCollection services) => 
            services.AddSingleton<IPortalContext, PortalContext>();
    }
}
