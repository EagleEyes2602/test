﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}