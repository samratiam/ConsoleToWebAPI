using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
namespace ConsoleToWebAPI{
    public class CustomMiddleware:IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next){
            await context.Response.WriteAsync("Hello from Custom Middleware - 1\n");
            await next(context);
            await context.Response.WriteAsync("Hello from Custom Middleware = 2\n");
        }
    }
}