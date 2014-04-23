using System.Web.Mvc;
using HipChatWeb.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace HipChatWeb
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();

      container.RegisterType<HipChatDbContext>();
      container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new InjectionConstructor(typeof(HipChatDbContext)));

      DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    }
  }
}