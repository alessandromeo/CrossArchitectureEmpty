using Microsoft.Extensions.DependencyInjection;

namespace CrossArchitecture.ApplicationServices
{
    public static class ApplicationServicesUnitRingExtensions
    {
        public static IServiceCollection AddApplicationServicesUnit(this IServiceCollection services) =>
            services.AddTransient<IApplicationService, ApplicationService>();
    }
}
