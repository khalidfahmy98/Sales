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
    public class TypesController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Types Operations";
            return View();
        }
        [IsLogged]
        public ActionResult DataView()
        {
            List<Types> types = TypesBLL.List().ToList();
            return View(types);
        }
        [IsLogged]
        public ActionResult Select(int Id = 0)
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            List<Types> types = TypesBLL.List().ToList();
            return View(types);
        }

        [IsLogged]
        public JsonResult Create(Types model)
        {
            if (TypesBLL.Add(model) != 0)
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
            TypesBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


    }
}