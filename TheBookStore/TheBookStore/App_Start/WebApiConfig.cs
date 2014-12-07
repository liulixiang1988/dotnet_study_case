using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TheBookStore.Infrastructure;

namespace TheBookStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new EnforceHttpsAttribute());

            config.MessageHandlers.Add(new RateLimitHandler());
            config.MessageHandlers.Add(new BasicAuthenticationHandler(new CustomPrincipalProvider()));

            config.Filters.Add(new AuthorizeAttribute());
            config.Formatters.Add(new BooksCsvFormatter());
        }
    }
}
