using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo.Filters;

public class RouteDemoFilter : IAsyncResourceFilter, IAsyncActionFilter, IOrderedFilter
{
    ILogger<RouteDemoFilter> _logger;

    public RouteDemoFilter(ILogger<RouteDemoFilter> logger)
    {
        _logger = logger;
    }

    public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
    {
        var routeData = context.HttpContext.GetRouteData();
        var routeTemplate = routeData.Routers.OfType<Route>()
            //.FirstOrDefault(r => r.Name == "UserRoute")
            .Select(r => r.ParsedTemplate)
            .Select(t => t.TemplateText);
        // join routeTemplate with ","
        var routeTemplateString = string.Join(",", routeTemplate);
        Console.WriteLine("RouteTemplate: {0}", routeTemplateString);
        Console.WriteLine("--------RouteDemoFilter: Route------------");
        foreach (var route in context.HttpContext.GetRouteData().Routers)
        {
            Console.WriteLine("route: {0}", route);
            if (route is Route route1)
            {
                Console.WriteLine("route1: {0}", route1.RouteTemplate);
            }
        }
        Console.WriteLine("--------RouteDemoFilter: RouteData------------");
        foreach (var routeDataValue in context.RouteData.Values)
        {
            Console.WriteLine("key: {0}, value: {1}", routeDataValue.Key, routeDataValue.Value);
        }
        Console.WriteLine("--------OnResourceExecution: Feature------------");
        foreach (var feature in context.HttpContext.Features)
        {
            Console.WriteLine("key: {0}, value: {1}", feature.Key, feature.Value);
        }

        var ed = context.HttpContext.GetEndpoint() as RouteEndpoint;
        Console.WriteLine("ed: {0}", ed?.RoutePattern.RawText);
        var endpointFeature = context.HttpContext.Features.Get<IEndpointFeature>();
        var endpoint = endpointFeature?.Endpoint;
        if (endpoint != null)
        {
            Console.WriteLine("--------OnResourceExecution: Endpoint------------");
            Console.WriteLine("Endpoint: {0}", endpoint.DisplayName);
            Console.WriteLine("Metadata: {0}", string.Join(", ", endpoint.Metadata));
        }
        
        var routeEndpoint = context.HttpContext.Features.Get<IRouteValuesFeature>();
        if (routeEndpoint != null)
        {
            Console.WriteLine("--------OnResourceExecution: RouteValues------------");
            foreach (var routeValue in routeEndpoint.RouteValues)
            {
                Console.WriteLine("key: {0}, value: {1}", routeValue.Key, routeValue.Value);
            }
        }
        await next();
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine("--------OnActionExecutionAsync: Route------------");
        var endpoint = context.HttpContext.GetEndpoint();  
        if (endpoint != null)  
        {  
            var routeAttribute = endpoint.Metadata.GetMetadata<RouteAttribute>();  
            string routeTemplate2 = routeAttribute?.Template;  
            if (routeTemplate2 != null)  
            {  
                // Do something with the route template  
            }  
            else  
            {  
                // Route template not found  
            }  
        }  
        else  
        {  
            // Endpoint not found  
        }  
   
        var routeData = context.HttpContext.GetRouteData();
        var routeTemplate = routeData.Routers.OfType<Route>()
            //.FirstOrDefault(r => r.Name == "UserRoute")
            .Select(r => r.ParsedTemplate)
            .Select(t => t.TemplateText);
        // join routeTemplate with ","
        var routeTemplateString = string.Join(",", routeTemplate);
        Console.WriteLine("RouteTemplate: {0}", routeTemplateString);
        Console.WriteLine("--------Action: Route------------");
        foreach (var route in context.HttpContext.GetRouteData().Routers)
        {
            Console.WriteLine("route: {0}", route);
            if (route is Route route1)
            {
                Console.WriteLine("route1: {0}", route1.RouteTemplate);
            }
        }
        Console.WriteLine("--------OnActionExecutionAsync: RouteData------------");
        foreach (var value in context.RouteData.Values)
        {
           Console.WriteLine("key: {0}, value: {1}", value.Key, value.Value); 
        }
        
        // iterate all the features in the context
        Console.WriteLine("--------OnActionExecutionAsync: Feature------------");
        foreach (var feature in context.HttpContext.Features)
        {
            Console.WriteLine("key: {0}, value: {1}", feature.Key, feature.Value);
        }
        await next();
    }

    public int Order { get; } = int.MaxValue;
}