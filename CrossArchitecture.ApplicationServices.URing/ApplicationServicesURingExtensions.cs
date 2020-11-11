using Microsoft.Extensions.DependencyInjection;

namespace CrossArchitecture.ApplicationServices
{
    public static class ApplicationServicesURingExtensions
    {
        public static IServiceCollection AddApplicationServicesUnit(this IServiceCollection services) =>
            services.AddSingleton<IApplicationService, ApplicationService>();
    }
}
