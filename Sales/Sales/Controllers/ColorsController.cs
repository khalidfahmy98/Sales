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
    public class ColorsController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Type Color ";
            return View();
        }
        [IsLogged]
        public ActionResult Operations()
        {
            ViewBag.Title = "Type colors Operations";
            return View();
        }

    }
}