using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace ConsoleToWebAPI
{
    public class Startup{
        public void ConfigureServices(IServiceCollection services){
            services.AddControllers();
            // Add the CustomMiddleware service
            // services.AddTransient<CustomMiddleware>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            // // Use the CustomMiddleware service
            // app.UseMiddleware<CustomMiddleware>();


            // // Insert new middleware
            // app.Use(async(context, next)=>
            // {
            //     await context.Response.WriteAsync("Hello from Use 1\n");
            //     await next();
            // });

            // // Implement Map method to map middleware to URL
            // app.Map("/samrat",CustomCode);

            // // Complete middleware execution and return to previous middleware
            // app.Run(async context => {
            //     await context.Response.WriteAsync("HEllo from Run 1\n");
            // });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });  
        }

        // Custom code for the URL
        // private void CustomCode(IApplicationBuilder app){
        //     app.Use(async(context, next)=>
        //     {
        //         await context.Response.WriteAsync("Hello from samrat\n");
        //     });
        // }
    }
}