﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTV.Models.ViewModels
{
    public class LoginViewModel
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}