﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WeppApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Admin", action = "Admin", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Dashboard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dashboard", action = "Dashboard", id = UrlParameter.Optional }
            );



            /*routes.MapRoute(
                name: "Dashboard",
                url: "admin/dashboard/{action}/{id}",
                defaults: new { controller = "Admin", action = "Admin", id = UrlParameter.Optional }
            );*/
        }
    }
}
