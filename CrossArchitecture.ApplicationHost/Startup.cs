using CrossArchitecture.ApplicationServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CrossArchitecture.ApplicationHost
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.
                AddApplicationServices().
                AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection().
                UseRouting().
                UseAuthorization().
                UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        }
    }
}
