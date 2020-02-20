using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTV.ResourceAccess.Entities;
//using QLTV.Service;
using Dapper;

namespace QLTV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var authen = Session["UserAuthentication"];
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string userName, string password)
        {
            if (userName == "vietqq" && password == "123456")
            {
                Session["UserAuthentication"] = "vietqq123456";
                return Json(new { code = 200 }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { code = 500 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}