using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints => 
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello From Web API App!");
                });

                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello From Web API App Test!");
                });
            });
        }
    }
}
