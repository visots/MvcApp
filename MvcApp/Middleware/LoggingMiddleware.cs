using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MvcApp.Models.DB;

namespace MvcApp.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        /// <summary>
        ///  Middleware-компонент должен иметь конструктор, принимающий RequestDelegate
        /// </summary>
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext context, ILoggerRepository repo)
        {
            Console.WriteLine($"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}");

            var request = new Request();
            request.Url = $"http://{context.Request.Host.Value + context.Request.Path}";
            await repo.WriteMessage(request);
            
            // Передача запроса далее по конвейеру
            await _next.Invoke(context);
        }
    }
}
