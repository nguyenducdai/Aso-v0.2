using Nop.Services.FieldWord;
using Nop.Web.Models.FieldWork;
using System.Web.Mvc;

namespace Nop.Web.Controllers
{
    public class FieldWorkController : BasePublicController
    { 
        FieldWorkService _fieldWorkService;

        public FieldWorkController(FieldWorkService fieldWorkService)
        {
            this._fieldWorkService = fieldWorkService;
        }

        public ActionResult getFieldWork()
        {
            var model = _fieldWorkService.GetAllFieldWork();
            return PartialView(model);
        }
    }
}