using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run");
            //});

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use1 \n");
                await next();
                await context.Response.WriteAsync("Hello from Use1 \n");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use2 \n");
                await next();
                await context.Response.WriteAsync("Hello from Use2 \n");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Request Completed \n");
            });

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllers();
            });
        }
    }
}
