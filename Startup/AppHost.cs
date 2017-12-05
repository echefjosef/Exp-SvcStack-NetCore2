using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Funq;
using HealthCheck.ServiceInterface;
using HealthCheck.ServiceModel;
using ServiceStack;

namespace Startup
{
    public class AppHost : AppHostBase
    {
        public AppHost(): base ("Exp ServiceStack & .Net Core 2 Service",
            typeof(HealthCheckService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            ConfigureRoutes();
        }

        private void ConfigureRoutes()
        {
            Routes.Add<HealthCheckRequest>("/healthcheck", ApplyTo.Get);
        }
    }
}
