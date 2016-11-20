using Backend;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace qwertyuiop.App_Start
{
    public class Bootstrapper
    {
        public void Setup()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            SetupDependencies(container);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private void SetupDependencies(Container container)
        {
            container.Register<IServiceA, ServiceA>();
            container.Register<IServiceC, ServiceC>();
            container.Register<IRepoA, RepoA>();
            container.Register<ServiceASettings>(() => new ServiceASettings(
                int.Parse(ConfigurationManager.AppSettings["someCount"]),
                ConfigurationManager.AppSettings["someString"]));
        }
    }
}