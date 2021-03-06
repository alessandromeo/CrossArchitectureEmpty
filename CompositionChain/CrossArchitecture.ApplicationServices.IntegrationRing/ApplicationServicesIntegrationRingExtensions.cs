﻿using CrossArchitecture.CoreServices;
using CrossArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CrossArchitecture.ApplicationServices
{
    public static class ApplicationServicesIntegrationRingExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
            services.
                AddCoreServicesUnit().
                AddInfrastructure().
                AddApplicationServicesUnit();
    }
}
