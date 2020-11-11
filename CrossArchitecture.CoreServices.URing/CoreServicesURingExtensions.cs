using Microsoft.Extensions.DependencyInjection;

namespace CrossArchitecture.CoreServices
{
    public static class CoreServicesURingExtensions
    {
        public static IServiceCollection AddCoreServicesUnit(this IServiceCollection services) =>
            services.AddSingleton<ICoreService, CoreService>();
    }
}
