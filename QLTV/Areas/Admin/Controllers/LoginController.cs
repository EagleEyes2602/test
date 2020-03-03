using QLTV.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(LoginViewModel model)
        {
            try
            {
                if (model.Email == "vietqq@gmail.com" && model.Password == "123456")
                {
                    Session["UserInformation"] = "vietqq@gmail.com";
                    return Json(new { Code = 200 }, JsonRequestBehavior.AllowGet);
                }
                return Json(new { Code = 500, ErrorMessage = "Đăng nhập thất bại" }, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new { Code = 500, ErrorMessage = "Đăng nhập thất bại" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}