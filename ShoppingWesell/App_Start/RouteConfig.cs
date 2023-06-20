﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShoppingWesell
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name 
                "{controller}/{action}/{id}", // URL with parameters 
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            ); 
        }
    }
}