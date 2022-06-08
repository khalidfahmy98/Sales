using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;
using Sales.Common;

namespace Sales.Controllers
{
    public class CustomersController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Customer";
            return View();
        }
        [IsLogged]
        public ActionResult Operations()
        {
            ViewBag.Title = " Customers Operations";
            return View();
        }

    }
}