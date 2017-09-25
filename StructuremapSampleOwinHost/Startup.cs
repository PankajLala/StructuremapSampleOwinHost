using Hangfire;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(StructuremapSampleOwinHost.Startup))]

namespace StructuremapSampleOwinHost
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseHangfireDashboard();
            appBuilder.UseHangfireServer();

        }
    }
}