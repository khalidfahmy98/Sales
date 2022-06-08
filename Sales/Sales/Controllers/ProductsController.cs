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
    public class ProductsController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Product";
            return View();
        }
        [IsLogged]
        public ActionResult Operations()
        {
            List<Products> products = ProductsBLL.List().ToList();
            ViewBag.Title = "Products Operations";
            return View(products);
        }
        [IsLogged]
        public JsonResult Create(Products model)
        {
            if (ProductsBLL.Add(model) != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult Del(int Id)
        {
            ProductsBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


    }
}