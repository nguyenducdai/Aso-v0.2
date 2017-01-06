using Nop.Web.Framework.Mvc.Routes;
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
            routes.MapRoute("Nop.Plugin.Teams.Aso.Index",
                "aso/index",
                new { controller = "FieldWord", action = "Index" },
                new[] { "Nop.Plugin.Teams.Aso.Controllers" }
           );

            routes.MapRoute("Nop.Plugin.Teams.Aso.Manage",
               "aso/case",
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

            //CREATE DOCUMENT
            routes.MapRoute("Nop.Plugin.Teams.Aso.CreateDocument",
              "download/create",
              new { controller = "DocumentAso", action = "CreateDocument" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            routes.MapRoute("Nop.Plugin.Teams.Aso.DoCreateDocument",
              "download/d-create",
              new { controller = "DocumentAso", action = "DoCreateDocument" },
              new[] { "Nop.Plugin.Teams.Aso.Controllers" }
            );

            routes.MapRoute("Nop.Plugin.Teams.Aso.ListDoc",
             "download/list",
             new { controller = "DocumentAso", action = "ListDoc" },
             new[] { "Nop.Plugin.Teams.Aso.Controllers" }
           );

            routes.MapRoute("Nop.Plugin.Teams.Aso.DelDoc",
            "download/del/{id}",
            new { controller = "DocumentAso", action = "DelDoc" },
            new { id = @"\d+" },
            new[] { "Nop.Plugin.Teams.Aso.Controllers" }
          );

          routes.MapRoute("Nop.Plugin.Teams.Aso.ArchiveDocument",
          "archive/document",
          new { controller = "DocumentAso", action = "ArchiveDocument" },
          new[] { "Nop.Plugin.Teams.Aso.Controllers" }
        );

            routes.MapRoute("Nop.Plugin.Teams.Aso.Detail",
            "case/detail/{id}",
            new { controller = "FieldWord", action = "Detail" },
             new { id = @"\d+" },
            new[] { "Nop.Plugin.Teams.Aso.Controllers" }
          );


            routes.MapRoute("Nop.Plugin.Teams.Aso.Download",
            "download/do/{id}",
            new { controller = "DocumentAso", action = "Download" },
             new { id = @"\d+" },
            new[] { "Nop.Plugin.Teams.Aso.Controllers" }
          );

        }
    }
}
