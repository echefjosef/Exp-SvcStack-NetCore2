using System;
using System.Collections.Generic;
using System.Text;
using HealthCheck.ServiceModel;
using ServiceStack;

namespace HealthCheck.ServiceInterface
{
    public class HealthCheckService : Service
    {
        public object Get(HealthCheckRequest request)
        {
            return "Service is up and running...";
        }
    }
}
