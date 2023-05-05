using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Filters;

namespace aspnet_demo.Filters;

public class BillFilter : IActionFilter, IAsyncActionFilter, IAlwaysRunResultFilter, IAsyncAlwaysRunResultFilter
    , IResourceFilter, IAsyncResourceFilter
{
    private readonly ILogger<BillFilter> _logger;

    public BillFilter(ILogger<BillFilter> logger)
    {
        _logger = logger;
    }

    public static string GetHttpMethod(RouteData routeData)
    {
        var controllerName = routeData.Values["controller"];
        var actionName = routeData.Values["action"];
        return $"{controllerName}#{actionName}";
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        _logger.LogInformation("OnActionExecuting, {}", GetHttpMethod(context.RouteData));
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        _logger.LogInformation("OnActionExecuted, {} {context}", GetHttpMethod(context.RouteData), context);
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (Configs.LocalValue.Value == null || !Configs.LocalValue.Value.StartsWith("From"))
        {
            context.HttpContext.Request.Headers.TryGetValue("x-local", out var local);

            Configs.LocalValue.Value = local.Count > 0
                ? local.ToString()
                : "From OnActionExecutionAsync" + System.DateTime.Now.Ticks;
            context.HttpContext.Request.Headers["x-local"] = Configs.LocalValue.Value;
            context.HttpContext.Response.Headers["x-local"] = Configs.LocalValue.Value;
        }

        _logger.LogInformation("OnActionExecutionAsync start, {} {} {context}", GetHttpMethod(context.RouteData),
            Configs.LocalValue.Value, context);
        try
        {
            await next();
        }
        finally
        {
            //q: object to json
            var json = JsonSerializer.Serialize(context.HttpContext.Request.Path);
            _logger.LogInformation(
                "OnActionExecutionAsync, {}, local {local}, http status code: {statusCode}, context {context}",
                GetHttpMethod(context.RouteData), Configs.LocalValue.Value,
                context.HttpContext.Response.StatusCode, json);
        }
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
        _logger.LogInformation("OnResultExecuting start, {} {context}", GetHttpMethod(context.RouteData), context);
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        _logger.LogInformation("OnResultExecuted start, {} {context}", GetHttpMethod(context.RouteData), context);
    }

    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        _logger.LogInformation("OnResultExecutionAsync {}, {}, {context}", GetHttpMethod(context.RouteData),
            Configs.LocalValue.Value, context);
        _logger.LogInformation("OnResultExecutionAsync, {}",
            context.HttpContext.Features.Get<FeatureDemo>()?.FeatureName);
        try
        {
            await next();
        }
        finally
        {
            var json = JsonSerializer.Serialize(context.HttpContext.Request.Path);
            _logger.LogInformation(
                "OnResultExecutionAsync, {}, local {}, http status code: {statusCode}, context {context}",
                GetHttpMethod(context.RouteData),
                Configs.LocalValue.Value,
                context.HttpContext.Response.StatusCode, json);
        }
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        _logger.LogInformation("OnResourceExecuting, {}, {context}", GetHttpMethod(context.RouteData), context);
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        _logger.LogInformation("OnResourceExecuted, {}, {context}", GetHttpMethod(context.RouteData), context);
    }

    public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
    {
        _logger.LogInformation("router:{}", context.RouteData.Values);
        if (Configs.LocalValue.Value == null || !Configs.LocalValue.Value.StartsWith("From"))
        {
            context.HttpContext.Request.Headers.TryGetValue("x-local", out var local);

            Configs.LocalValue.Value = local.Count > 0
                ? local.ToString()
                : "From OnResourceExecutionAsync" + System.DateTime.Now.Ticks;
            context.HttpContext.Request.Headers["x-local"] = Configs.LocalValue.Value;
            context.HttpContext.Response.Headers["x-local"] = Configs.LocalValue.Value;
        }

        _logger.LogInformation("OnResourceExecutionAsync,{}, {context}", GetHttpMethod(context.RouteData), context);
        try
        {
            await next();
        }
        finally
        {
            var json = JsonSerializer.Serialize(context.HttpContext.Request.Path);
            _logger.LogInformation(
                "OnResourceExecutionAsync, {}, local {}, http status code: {statusCode}, context {context}",
                GetHttpMethod(context.RouteData),
                Configs.LocalValue.Value,
                context.HttpContext.Response.StatusCode, json);
        }
    }
}