using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Teams.Aso.Data;
using Nop.Core.Data;
using Nop.Core.Plugins;
using System.Web.Mvc;
using System.Web;
using System.IO;
using Nop.Web.Framework.Kendoui;

namespace Nop.Plugin.Teams.Aso.Controllers
{
    public class DocumentAsoController : BasePluginController
    {
        private IRepository<DownLoadRecord> _iRepository;

        public PluginDescriptor PluginDescriptor
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DocumentAsoController(IRepository<DownLoadRecord> iRepository)
        {
            _iRepository = iRepository;
        }

        public ActionResult viewDocument()
        {
            var model = _iRepository.Table.ToList();
            return View("~/Plugins/Teams.Aso/Views/Widgets/DownloadWinget.cshtml",model);
        }

        [HttpPost]
        public ActionResult ListDoc(DataSourceRequest command)
        {
            var list = _iRepository.Table.ToList();

            var data = new DataSourceResult
            {
                Data = list,
                Total = list.Count
            };
            return Json(data);
        }


        public ActionResult CreateDocument()
        {

            return View("~/Plugins/Teams.Aso/Views/Document/CreateDocument.cshtml");
        }

        public ActionResult DelDoc(int id)
        {
            var d = _iRepository.GetById(id);
            if(d != null)
            {
                var path = Path.Combine(Server.MapPath("~/Content/FIleDownload/"), d.File);
                var pathImg = Path.Combine(Server.MapPath("~/Content/FIleDownload/img/"), d.Image);
                this.removeFile(path);
                this.removeFile(pathImg);
                _iRepository.Delete(d);
                ViewBag.Alert = "Xóa thành công";
            }
            return RedirectToAction("/aso/index");
        } 

        private void removeFile(string path)
        {
            if ((System.IO.File.Exists(path)))
            {
                System.IO.File.Delete(path);
            }
        }

        [HttpPost]
        public ActionResult DoCreateDocument(DownLoadRecord downLoad , HttpPostedFileBase file , HttpPostedFileBase img)
        {
            DownLoadRecord dl = new DownLoadRecord();
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var fileDoc = Path.GetFileName(file.FileName);
                    var fileImg = Path.GetFileName(img.FileName);

                    // move file to folder
                    var path = Path.Combine(Server.MapPath("~/Content/FIleDownload/"), fileDoc);
                    var pathImg = Path.Combine(Server.MapPath("~/Content/FIleDownload/img/"), fileImg);
                    if (!System.IO.File.Exists(path))
                    {
                        file.SaveAs(path);
                    }

                    if (!System.IO.File.Exists(pathImg))
                    {
                        img.SaveAs(pathImg);
                    }
                    var date = DateTime.Now.ToString("yyyy-MM-dd");
                    dl.Create_at = Convert.ToDateTime(date);
                    dl.Image = img.FileName;
                    dl.File = file.FileName;
                    dl.Title = downLoad.Title;
                    _iRepository.Insert(dl);
                    ViewBag.Alert = "Tải tài liệu lên thành công";
                }
            }
            return RedirectToAction("CreateDocument");
        }


        public ActionResult ArchiveDocument()
        {
            var model = _iRepository.Table.ToList();
            return View("~/Plugins/Teams.Aso/Views/Widgets/PageAchiverDownloand.cshtml",model);
        }
    }
}
