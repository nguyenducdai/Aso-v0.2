using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Teams.Aso.Data;
using Nop.Core.Data;
using System.Web.Mvc;

namespace Nop.Plugin.Teams.Aso.Controllers
{
    public class DownloadDocumentController: BasePluginController
    {
        private IRepository<DownLoadRecord> _iRepository;

        public DownloadDocumentController(IRepository<DownLoadRecord> iRepository)
        {
            _iRepository = iRepository;
        }

        public ActionResult HomeView()
        {
            return View("~/Plugins/Teams.Aso/Views/Widgets/DownloadWinget.cshtml");
        }
    }
}
