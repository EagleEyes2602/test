using QLTV.Models.Entity;
using QLTV.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    public class EmployeeController : BaseController
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
                    employee.CreatedTime = DateTime.Now;
                    employee.CreatedBy = GetUserInformation();
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
                return Json(new { StatusCode = 505, Message = "Lỗi thêm mới" }, JsonRequestBehavior.AllowGet);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee">Model chứa thông tin nhân viên</param>
        /// <returns></returns>
        public JsonResult Update(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Sửa bản ghi trong DB
                    Employee employeeModified = new Employee();
                    employeeModified.Code = employee.Code;
                    employeeModified.FirstName = employee.FirstName;
                    employeeModified.LastName = employee.LastName;
                    employeeModified.Email = employee.Email;
                    employeeModified.DOB = employee.DOB;
                    employeeModified.Phone = employee.Phone;
                    employeeModified.Gender = employee.Gender;
                    employeeModified.CreatedTime = employee.CreatedTime;
                    employeeModified.CreatedBy = employee.CreatedBy;
                    employeeModified.UpdatedTime = DateTime.Now;
                    employeeModified.UpdatedBy = GetUserInformation();
                    employeeModified.Notes = employee.Notes;
                    employeeModified.Status = employee.Status;
                    db.Entry(employee).State = EntityState.Modified;
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
                return Json(new { StatusCode = 505, Message = "Lỗi thêm mới" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Delete(int employeeId)
        {
            try
            {
                // Xóa bản ghi khỏi db
                Employee employee = db.Employees.Find(employeeId);
                db.Employees.Remove(employee);
                db.SaveChanges();
                return Json(new { StatusCode = 200 }, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new { StatusCode = 505, Message = "Lỗi thêm mới" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}