using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTV.ResourceAccess.Entities;
//using QLTV.Service;
using Dapper;
using QLTV.Services;
using QLTV.Models.Entity;

namespace QLTV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GenericService<Employee> employee = new GenericService<Employee>();

            DynamicParameters param = new DynamicParameters();

            // Lấy 1 bản ghi
            //param.Add("@Id", 1);
            //var employeeData = employee.ExcuteSingle("Employee_GetById", param);

            // Lấy nhiều bản ghi
            //var employeeData = employee.ExcuteMany("Employee_GetAll", null);

            // Insert update deleteparam.Add("@Code", 1);
            param.Add("@Code", "123");
            param.Add("@FirstName", "qwe");
            param.Add("@LastName", "ert");
            param.Add("@Email", "abc@gmail.com");
            param.Add("@Password", "asjkdh");
            param.Add("@Phone", "askjdh");
            param.Add("@Gender", 1);
            param.Add("@DOB", DateTime.Now);
            param.Add("@CreatedBy", 1);
            param.Add("@Notes", "");
            param.Add("@Status", 1);
            var employeeAdd = employee.ExcuteNoneQuery("Employee_Add", param);

            var employeeData = employee.ExcuteMany("Employee_GetAll", null);
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