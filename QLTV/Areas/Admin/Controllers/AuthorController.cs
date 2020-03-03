using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Admin/Author
        public ActionResult Index()
        {
            return View();
        }
    }
}