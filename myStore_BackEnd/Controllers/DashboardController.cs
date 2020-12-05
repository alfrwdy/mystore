﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myStore_BackEnd.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if(Session["user_level"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}