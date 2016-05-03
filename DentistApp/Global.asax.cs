using Autofac.Integration.WebApi;
using DentistApp.App_Start;
using DentistApp.App_Start.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DentistApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Build IoC container
            var container = ContainerConfig.Configure();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
