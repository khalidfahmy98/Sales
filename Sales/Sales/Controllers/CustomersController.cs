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
            List<Customers> customer = CustomersBLL.List().ToList();
            ViewBag.Title = " Customers Operations";
            return View(customer);
        }
        [IsLogged]
        public JsonResult Create(Customers model)
        {
            if (CustomersBLL.Add(model) != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Phone Or Mobile  Already Registered" }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult Del(int Id)
        {
            if (Id > 1)
            {
                CustomersBLL.Delete(Id);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }


    }
}