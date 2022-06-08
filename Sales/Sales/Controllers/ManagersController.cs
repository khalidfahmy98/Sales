using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Common;

namespace Sales.Controllers
{
    public class ManagersController : Controller
    {
        [IsLogged]
        [IsManager]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Manager";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult Operations()
        {
            ViewBag.Title = "Managers Operations";
            return View();
        }
    }
}