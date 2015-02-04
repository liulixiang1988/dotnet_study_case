using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;

namespace WebApi2Book.Web.Common
{
    public class NamespaceHttpControllerSelector:IHttpControllerSelector
    {
        private readonly HttpConfiguration _configuration;
        private readonly Lazy<Dictionary<string, HttpControllerDescriptor>> _controllers;

        public NamespaceHttpControllerSelector(HttpConfiguration config)
        {
            _configuration = config;
            _controllers = new Lazy<Dictionary<string, HttpControllerDescriptor>>(InitializeControllerDictionary);
        }

        /// <summary>
        /// 初始化控制器字典
        /// </summary>
        /// <returns>控制器字典</returns>
        private Dictionary<string, HttpControllerDescriptor> InitializeControllerDictionary()
        {
            //StringComparer.OrdinalIgnoreCase执行不区分大小写比较
            var dictionary = new Dictionary<string, HttpControllerDescriptor>(StringComparer.OrdinalIgnoreCase);

            //_configuration.Services获取与此实例关联的默认服务的容器
            var assembliesResolver = _configuration.Services.GetAssembliesResolver();
            var controllersResolver = _configuration.Services.GetHttpControllerTypeResolver();

            //返回可用于应用程序的控制器的列表
            var controllerTypes = controllersResolver.GetControllerTypes(assembliesResolver);

            foreach (var controllerType in controllerTypes)
            {
                //获取控制器的命名空间，并进行分解
                var segments = controllerType.Namespace.Split(Type.Delimiter);
                //移除Controller后缀，获得控制器名称
                var controllerName =
                    controllerType.Name.Remove(controllerType.Name.Length -
                                               DefaultHttpControllerSelector.ControllerSuffix.Length);

                //CultureInfo.InvariantCulture跟区域无关
                var controllerKey = String.Format(CultureInfo.InvariantCulture, "{0}.{1}",
                    segments[segments.Length - 1], controllerName);

                if (!dictionary.ContainsKey(controllerKey))
                {
                    //HttpControllerDescriptor的3个参数的意义：配置、控制器名称、控制器类型
                    dictionary[controllerKey] = 
                        new HttpControllerDescriptor(_configuration, controllerType.Name,controllerType);
                }
            }
            return dictionary;
        }

        public HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var routeData = request.GetRouteData();
            if (routeData == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            var controllerName = GetControllerName(routeData);
            if (controllerName == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            var namespaceName = GetVersion(routeData);
            if (namespaceName == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            var controllerKey = string.Format(CultureInfo.InvariantCulture, "{0}.{1}",
                namespaceName, controllerName);

            HttpControllerDescriptor controllerDescriptor;
            if (_controllers.Value.TryGetValue(controllerKey, out controllerDescriptor))
            {
                return controllerDescriptor;
            }
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        public IDictionary<string, HttpControllerDescriptor> GetControllerMapping()
        {
            return _controllers.Value;
        }

        /// <summary>
        /// 根据IHttpRouteData返回控制器名称
        /// </summary>
        /// <param name="routeData">IHttpRouteData</param>
        /// <returns>返回控制器名称或者null</returns>
        private string GetControllerName(IHttpRouteData routeData)
        {
            //返回子路由
            var subRoute = routeData.GetSubRoutes().FirstOrDefault();
            if (subRoute == null)
            {
                return null;
            }

            var dataTokenValue = subRoute.Route.DataTokens.First().Value;
            if (dataTokenValue == null)
            {
                return null;
            }

            var controllerName = ((HttpActionDescriptor[]) dataTokenValue).First()
                .ControllerDescriptor.ControllerName.Replace("Controller", string.Empty);
            return controllerName;
        }

        /// <summary>
        /// 返回版本
        /// </summary>
        private string GetVersion(IHttpRouteData routeData)
        {
            //返回子路由
            var subRoute = routeData.GetSubRoutes().FirstOrDefault();
            if (subRoute == null)
            {
                return null;
            }

            return GetRouteVariable<string>(subRoute, "apiVersion");
        }

        /// <summary>
        /// 获取Route变量
        /// </summary>
        private T GetRouteVariable<T>(IHttpRouteData routeData, string name)
        {
            object result;
            if (routeData.Values.TryGetValue(name, out result))
            {
                return (T) result;
            }
            return default(T);
        }
    }
}
