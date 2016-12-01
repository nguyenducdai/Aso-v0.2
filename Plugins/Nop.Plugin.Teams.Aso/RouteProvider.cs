﻿using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nop.Plugin.Teams.Aso
{
    class RouteProvider : IRouteProvider
    {
        public int Priority
        {
            get
            {
                return 0;
            }
        }

        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Nop.Plugin.Teams.Aso.Manage",
                "FieldWork/Manage",
                new { controller = "FieldWord", action = "Manage" },
                new[] { "Nop.Plugin.Teams.Aso.Controllers" }
           );

            routes.MapRoute("Nop.Plugin.Teams.Aso.List",
              "FieldWork/List",
              new { controller = "FieldWord", action = "List" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            ///Aso/FieldWord/Create
            routes.MapRoute("Nop.Plugin.Teams.Aso.Add",
              "FieldWork/Create",
              new { controller = "FieldWord", action = "Add" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            ///Aso/FieldWord/Create
            routes.MapRoute("Nop.Plugin.Teams.Aso.AddPost",
              "FieldWork/AddPost",
              new { controller = "FieldWord", action = "AddPost" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            /////Aso dell
            routes.MapRoute("Nop.Plugin.Teams.Aso.Del",
              "FieldWork/Del/{id}",
              new { controller = "FieldWord", action = "Del" },
              new { id = @"\d+" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            /////Aso del
            routes.MapRoute("Nop.Plugin.Teams.Aso.Update",
              "FieldWork/Update/{id}",
              new { controller = "FieldWord", action = "Update" },
              new { id = @"\d+" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            /// Do update
            routes.MapRoute("Nop.Plugin.Teams.Aso.DoUpdate",
               "FieldWork/DoUpdate",
               new { controller = "FieldWord", action = "DoUpdate" },
               new[] { "Nop.Plugin.Teams.Aso.Controllers" }
             );
        }
    }
}