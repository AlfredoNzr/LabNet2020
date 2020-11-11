using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PracticeEF.Interfaces.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "InsertUpdateCategories",
                url: "{controller}/InsertUpdate/{id}",
                defaults: new { controller = "Categories", action = "InsertUpdate", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "InsertUpdateCustomers",
                url: "{controller}/InsertUpdate/{id}",
                defaults: new { controller = "Customers", action = "InsertUpdate", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
