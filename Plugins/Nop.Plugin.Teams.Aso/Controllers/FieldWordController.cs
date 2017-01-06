using Nop.Core.Data;
using Nop.Plugin.Teams.Aso.Data;
using Nop.Services.Cms;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Kendoui;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nop.Core.Plugins;
using System.Collections.Generic;
using System.Web.Routing;

namespace Nop.Plugin.Teams.Aso.Controllers
{
    public class FieldWordController : BasePluginController
    {
        private IRepository<FieldWorkRecord> _iRepository;

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

        public FieldWordController(IRepository<FieldWorkRecord> iRepository)
        {
            _iRepository = iRepository;
        }

        public FieldWordController()
        {
           
        }
        public ActionResult Index()
        {
            return View("~/Plugins/Teams.Aso/Views/FieldWork/Index.cshtml");
        }

        public ActionResult Manage()
        {
            return View("~/Plugins/Teams.Aso/Views/FieldWork/Manage.cshtml");
        }

        [HttpPost]
        public ActionResult List(DataSourceRequest command)
        {
            var list = _iRepository.Table.ToList();

            var data = new DataSourceResult
            {
                Data = list,
                Total = list.Count
            };
            return Json(data);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("~/Plugins/Teams.Aso/Views/FieldWork/Add.cshtml");
        }

        [HttpPost]
        public ActionResult AddPost(FieldWorkRecord fwRecord, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    var fileName = Path.GetFileName(Image.FileName);

                    // move file to folder
                    var path = Path.Combine(Server.MapPath("~/Content/Images/Thumbs/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Error = " File ảnh đã tồn tại";
                    }
                    else
                    {
                        Image.SaveAs(path);
                    }
                    var date = DateTime.Now.ToString("yyyy-MM-dd");
                    fwRecord.Create_at = Convert.ToDateTime(date);
                    fwRecord.Image = Image.FileName;
                    _iRepository.Insert(fwRecord);
                    return RedirectToAction("Manage");
                }
            }
            return View("~/Plugins/Teams.Aso/Views/FieldWork/Add.cshtml");
        }

        ///[HttpPost]
        public ActionResult Del(int id)
        {
            var result = _iRepository.GetById(id);
            if (result != null)
            {
                _iRepository.Delete(result);
            }
            return RedirectToAction("Manage");
        }

        public ActionResult Update(int id)
        {
            var data = _iRepository.GetById(id);
            return View("~/Plugins/Teams.Aso/Views/FieldWork/Edit.cshtml", data);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult DoUpdate(FieldWorkRecord fWord, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file == null)
                {
                    var fw = _iRepository.GetById(fWord.Id);
                    var date = DateTime.Now.ToString("yyyy-MM-dd");
                    fw.Title = fWord.Title;
                    fw.Descaption = fWord.Descaption;
                    fw.Content = fWord.Content;
                    fw.Create_at = Convert.ToDateTime(date);
                    fw.Image = fWord.Image;
                    fw.MetaTitle = fWord.MetaTitle;
                    fw.MetaDescription = fWord.MetaDescription;
                    fw.MetaKeywords = fWord.MetaKeywords;
                    _iRepository.Update(fw);
                }
                else
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Images/Thumbs/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.DuppError = "anh da ton tai";
                    }
                    else
                    {
                        file.SaveAs(path);
                    }
                    var fw = _iRepository.GetById(fWord.Id);
                    var date = DateTime.Now.ToString("yyyy-MM-dd");
                    fw.Title = fWord.Title;
                    fw.Descaption = fWord.Descaption;
                    fw.Content = fWord.Content;
                    fw.Create_at = Convert.ToDateTime(date);
                    fw.Image = file.FileName;
                    fw.MetaTitle = fWord.MetaTitle;
                    fw.MetaDescription = fWord.MetaDescription;
                    fw.MetaKeywords = fWord.MetaKeywords;
                    _iRepository.Update(fw);
                }
            }

            return RedirectToAction("Manage");
        }

        public ActionResult Configure()
        {
            return View("~/Plugins/Teams.Aso/Views/Widgets/Configure.cshtml");
        }

        public ActionResult HomeView()
        {
            var data = _iRepository.Table.ToList();
            return View("~/Plugins/Teams.Aso/Views/Widgets/PublicInfo.cshtml",data);
        }
        public ActionResult viewLv()
        {
            return View("~/Plugins/Teams.Aso/Views/Widgets/DownloadWinget.cshtml");
        }

        public ActionResult Detail(int id)
        {
            var data = _iRepository.GetById(id);
            return View("~/Plugins/Teams.Aso/Views/Widgets/DetailActicle.cshtml",data);
        }

    }
}