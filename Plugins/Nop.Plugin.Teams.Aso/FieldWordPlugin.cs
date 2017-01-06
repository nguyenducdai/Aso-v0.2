using Nop.Core.Plugins;
using Nop.Plugin.Teams.Aso.Data;
using Nop.Services.Cms;
using Nop.Services.Localization;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

namespace Nop.Plugin.Teams.Aso
{
    public class FieldWordPlugin : BasePlugin, IAdminMenuPlugin ,IWidgetPlugin
    {
        private readonly FieldWordRecordContext _context;
        private ILocalizationService _localizationService;

        public FieldWordPlugin(FieldWordRecordContext context, ILocalizationService localizationService)
        {
            _context = context;
            _localizationService = localizationService;
        }

        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "FieldWord";
            routeValues = new RouteValueDictionary()
           {
               { "Namespaces", "Nop.Plugin.Teams.Aso.Controllers" },
               { "area", null }
           };

            actionName = "Configure";
            controllerName = "DownloadDocument";
            routeValues = new RouteValueDictionary()
           {
               { "Namespaces", "Nop.Plugin.Teams.Aso.Controllers" },
               { "area", null }
           };
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "";
            controllerName = "";
            routeValues = new RouteValueDictionary
            {
                {"Namespaces", "Nop.Plugin.Teams.Aso.Controllers"},
                {"area", null},
                {"widgetZone", widgetZone}
            };

            if (widgetZone.Equals("GetWidget_linhvuc"))
            {
                actionName = "HomeView";
                controllerName = "FieldWord";
                routeValues = new RouteValueDictionary
                {
                    {"Namespaces", "Nop.Plugin.Teams.Aso.Controllers"},
                    {"area", null},
                    {"widgetZone", widgetZone}
                };
            }
            if (widgetZone.Equals("GetWidget_download_aso"))
            {
                actionName = "viewDocument";
                controllerName = "DocumentAso";
                routeValues = new RouteValueDictionary
                {
                    {"Namespaces", "Nop.Plugin.Teams.Aso.Controllers"},
                    {"area", null},
                    {"widgetZone", widgetZone}
                };
            }

            if (widgetZone.Equals("Archive"))
            {
                actionName = "ArchiveDocument";
                controllerName = "DocumentAso";
                routeValues = new RouteValueDictionary
                {
                    {"Namespaces", "Nop.Plugin.Teams.Aso.Controllers"},
                    {"area", null},
                    {"widgetZone", widgetZone}
                };
            }

            if (widgetZone.Equals("Case"))
            {
                actionName = "Detail";
                controllerName = "FieldWord";
                routeValues = new RouteValueDictionary
                {
                    {"Namespaces", "Nop.Plugin.Teams.Aso.Controllers"},
                    {"area", null},
                    {"widgetZone", widgetZone}
                };
            }
        }

        public IList<string> GetWidgetZones()
        {
            //,"GetWidget_download" 
            return new List<string>() { "GetWidget_linhvuc", "GetWidget_download_aso","Archive","Case"};
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        // Add Item menu
        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "Aso.Team",
                Title = "Aso Company",
                ControllerName = "FieldWord",
                ActionName = "Index",
                Visible = true,
                RouteValues = new RouteValueDictionary() {
                    { "area", null } },
                IconClass = "fa-dot-circle-o"
            };

            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Content management");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }



        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }
       }
}