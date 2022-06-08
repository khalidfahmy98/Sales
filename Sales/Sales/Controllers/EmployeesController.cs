using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Entity;
using Sales.Common;

namespace Sales.Controllers
{
    public class EmployeesController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Employee";
            return View();
        }
        [IsLogged]
        public ActionResult Operations()
        {
            ViewBag.Title = " Employee Operations";
            return View();
        }

    }
}