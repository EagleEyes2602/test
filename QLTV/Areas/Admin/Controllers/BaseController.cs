using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // UserId, Controller, action
            // Xử lý request
            if (filterContext.HttpContext.Session["UserInformation"] == null)
            {
                filterContext.Result = new RedirectResult("~/Login/Index");
            }
        }

        public int GetUserInformation()
        {
            if (Session["UserInformation"] != null)
            {
                return int.Parse(Session["UserInformation"].ToString());
            }
            return 0;
        }
    }
}