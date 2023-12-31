﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MASAJES
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SESIONES_MASAJES", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "GananciasMensuales",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Ganancias", action = "MostrarGananciasMensuales", id = UrlParameter.Optional }
            );
        }
    }
}
