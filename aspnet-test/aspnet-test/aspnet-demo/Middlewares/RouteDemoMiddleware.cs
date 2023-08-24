namespace aspnet_demo.Middlewares;

public class RouteDemoMiddleware
{
    private readonly RequestDelegate _next;

    public RouteDemoMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        var ed = httpContext.GetEndpoint() as RouteEndpoint;
        Console.WriteLine("ed: {0}", ed?.RoutePattern.RawText);
        await _next(httpContext);
    }
}