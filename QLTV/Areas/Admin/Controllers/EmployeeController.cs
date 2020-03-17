using QLTV.Models.Entity;
using QLTV.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        public QLTVEntities db = new QLTVEntities();
        // GET: Admin/Employee
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Pagging(int pageIndex = 1, int pageSize = 1)
        {
            EmployeeViewModel model = new EmployeeViewModel();
            int upper = (pageIndex - 1) * pageSize;
            var emps = db.Employees.OrderBy(x => x.Id);
            model.Employees = emps.Skip(upper).Take(pageSize).ToList();
            model.PageIndex = pageIndex;
            model.PageSize = pageSize;
            model.TotalRecord = emps.Count();
            decimal totalPage = (decimal)model.TotalRecord / model.PageSize;
            model.TotalPage = decimal.ToInt32(Math.Ceiling(totalPage));
            return PartialView(model);
        }

        public JsonResult Add(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Thêm mới vào DB
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return Json(new { StatusCode = 200 }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    // Tên input , lỗi
                    IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                    return Json(new { StatusCode = 500, Message = allErrors.FirstOrDefault().ErrorMessage }, JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json(new { StatusCode = 505, Message="Lỗi thêm mới" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}