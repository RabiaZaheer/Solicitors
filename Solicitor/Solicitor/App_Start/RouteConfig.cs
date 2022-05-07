using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Solicitor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
               name: "CustomPageUrl",
               url: "{controller}/{action}/{pageUrl}",
               defaults: new { controller = "Services", action = "Service" }
           );

            routes.MapRoute(
                name: "ServiceSideBar",
                url: "{controller}/{action}/{serviceID}/{serviceDetailID}",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
