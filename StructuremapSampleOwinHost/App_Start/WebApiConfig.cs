using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using StructureMap.Graph;
using System.Web.Http.Dispatcher;
using Hangfire.StructureMap;
using WebApi.StructureMap;

namespace StructuremapSampleOwinHost
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            var container = new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });
            });

            config.DependencyResolver = new DependencyResolver(container);
            Hangfire.GlobalConfiguration.Configuration.UseStructureMapActivator(container);

            
            

        }
    }
}
