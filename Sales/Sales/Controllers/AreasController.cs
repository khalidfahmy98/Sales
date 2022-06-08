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
    public class AreasController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Areas Operations";
            return View();
        }
    }
}