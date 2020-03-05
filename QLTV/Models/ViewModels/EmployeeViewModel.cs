using QLTV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTV.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalPage { get; set; }
        public int TotalRecord { get; set; }
    }
}