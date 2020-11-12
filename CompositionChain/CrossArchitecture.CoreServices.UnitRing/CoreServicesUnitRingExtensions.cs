using Microsoft.Extensions.DependencyInjection;

namespace CrossArchitecture.CoreServices
{
    public static class CoreServicesUnitRingExtensions
    {
        public static IServiceCollection AddCoreServicesUnit(this IServiceCollection services) =>
            services.AddSingleton<ICoreService, CoreService>();
    }
}
