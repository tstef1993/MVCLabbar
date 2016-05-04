using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Labb1MVC
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
                name: "Sell",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sell", action = "B2B", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LifeControllerSuperMario",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LifeController", action = "SuperMario", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LifeControllerHealth",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LifeController", action = "Health", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                    name: "LifeControllerLive",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "LifeController", action = "Live", id = UrlParameter.Optional }
                );


            routes.MapRoute(
                name: "LaserControllerSabel",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LaserController", action = "Sabel", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LaserControllerPointer",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LaserController", action = "Pointer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LaserControllerEye",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LaserController", action = "Eye", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LaserControllerPrinter",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LaserController", action = "Printer", id = UrlParameter.Optional }
            );
        }
    }
}
