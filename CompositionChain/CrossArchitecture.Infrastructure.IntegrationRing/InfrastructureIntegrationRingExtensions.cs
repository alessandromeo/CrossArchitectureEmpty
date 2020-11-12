using Microsoft.Extensions.DependencyInjection;

namespace CrossArchitecture.Infrastructure
{
    public static class InfrastructureIntegrationRingExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) =>
            services.AddSingleton<IInfrastructureEndpoint, InfrastructureEndpoint>();
    }
}
