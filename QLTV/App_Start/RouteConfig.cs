using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QLTV
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "admin-login",
                url: "admin-login",
                defaults: new { controller = "Login", action = "Index" },
                namespaces: new[] { "QLTV.Areas.Admin.Controllers" }
               );
            routes.MapRoute(
                    name: "Admin-default",
                    url: "admin/{controller}/{action}/{id}",
                    defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                    namespaces: new[] { "QLTV.Areas.Admin.Controllers" }
                   );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
