﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;
using Sales.Common;

namespace Sales.Controllers
{
    public class ReportingController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Day Report ";
            return View();
        }
        [IsLogged]
        public ActionResult Dataview()
        {

            return View();
        }
    }
}