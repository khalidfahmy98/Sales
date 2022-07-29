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
            List<Colors> Colors = ColorsBLL.List().ToList();
            ViewBag.Title = "Type colors Operations";
            return View(Colors);
        }

        [IsLogged]
        public ActionResult DataView()
        {
            List<Colors> Colors = ColorsBLL.List().ToList();
            return View(Colors);
        }
        [IsLogged]
        public ActionResult Select(int Id = 0 )
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            List<Colors> Colors = ColorsBLL.List().ToList();
            return View(Colors);
        }
        [IsLogged]
        public JsonResult Edit(Colors model)
        {
            if (ColorsBLL.Edit(model))
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }

        [IsLogged]
        public JsonResult Create(Colors model)
        {
            if (ColorsBLL.Add(model) != 0)
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
            ColorsBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
    }
}