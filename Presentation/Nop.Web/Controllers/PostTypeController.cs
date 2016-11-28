using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nop.Web.Controllers
{
    public class PostTypeController : Controller
    {
        // GET: PostType
        public ActionResult ListPost()
        {
            return PartialView();
        }
    }
}