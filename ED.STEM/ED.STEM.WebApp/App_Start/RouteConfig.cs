using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ED.STEM.WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                null,
                "",
                new
                {
                    controller = "STEMProgram",
                    action = "List",
                    category = (string)null,
                    page = 1
                }
            );

            routes.MapRoute(
                null,
                "Page{page}",
                new { controller = "STEMProgram", action = "List", category = (string)null },
                new { page = @"\d+" }
            );

            routes.MapRoute(
                null,
                "{category}",
                new { controller = "STEMProgram", action = "List", page = 1 }
            );

            routes.MapRoute(
                null,
                "{category}/Page{page}",
                new { controller = "STEMProgram", action = "List" },
                new { page = @"\d+" }
            );

            routes.MapRoute(null, "{controller}/{action}");

            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //             name: null,
            //             url: "Page{page}",
            //             defaults: new { controller = "STEMProgram", action = "List" }
            //         );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "STEMProgram", action = "List", id = UrlParameter.Optional }
            //);
        }
    }
}
