using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using StructureMap.Graph;
using Hangfire.StructureMap;
using Hangfire;
using StructuremapSampleOwinHost.Utilities;
using StructuremapSampleOwinHost;

namespace StructuremapSampleOwinHostOwinHost
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //private BackgroundJobServer _backgroundJobServer;

        protected void Application_Start()
        {


            System.Web.Http.GlobalConfiguration.Configure(WebApiConfig.Register);

            Hangfire.GlobalConfiguration.Configuration.UseSqlServerStorage(@"Server=XIPL6L398\SQLEXPRESS; Database=Hangfire;uid=XIPL\pankaj.lala;Password=Admin@123;Integrated Security=true");
            
            RecurringJob.AddOrUpdate<EmailService>(myService => myService.SendMail("my mail"), Cron.Minutely);
        }
    }
}
