using System.Diagnostics;

namespace lesson17_WebApi
{
    public class RequestLoggingMiddleware
    {

        private readonly RequestDelegate _next;
        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var method = context.Request.Method;   
            var url = context.Request.Path;        
            var timestamp = DateTime.Now;
            var stopwatch = Stopwatch.StartNew();
           
        
            await _next(context);
            stopwatch.Stop();
            Console.WriteLine($"Request took {stopwatch.Elapsed.TotalSeconds} seconds");


        }
    }
}
