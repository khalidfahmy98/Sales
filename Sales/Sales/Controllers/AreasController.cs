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
        [IsLogged]
        public ActionResult DataView()
        {
            List<Areas> types = AreasBLL.List().ToList();
            return View(types);
        }
        [IsLogged]
        public ActionResult Select(int Id = 0)
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            List<Areas> types = AreasBLL.List().ToList();
            return View(types);
        }

        [IsLogged]
        public JsonResult Create(Areas model)
        {
            if (AreasBLL.Add(model) != 0)
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
            AreasBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }

    }
}