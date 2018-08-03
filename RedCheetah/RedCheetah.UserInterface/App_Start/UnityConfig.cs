using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using RedCheetah.Core.Interface;
using RedCheetah.UserInterface.Services;
using RedCheetah.Infrastructure;

namespace RedCheetah.UserInterface
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            container.RegisterType<ISector, SectorSvc>();
            container.RegisterType<IChannel, ChannelSvc>();
            container.RegisterType<ILocation, LocationSvc>();
            container.RegisterType<IModem, ModemSvc>();
            container.RegisterType<IActiveDirectory, ActiveDirectorySvc>();
            container.RegisterType<ISwiftUtility, SwiftUtilitySvc>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}