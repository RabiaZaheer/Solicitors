using Solicitor.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Solicitor
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType(typeof(IRespository<>), typeof(Repository<>));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}