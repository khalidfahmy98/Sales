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
    public class SpecialsController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Specials Operations";
            return View();
        }
        [IsLogged]
        public ActionResult DataView()
        {
            List<Specials> types = SpecialsBLL.List().ToList();
            return View(types);
        }
        [IsLogged]
        public JsonResult Create(Specials model)
        {
            if (SpecialsBLL.Add(model) != 0)
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
            SpecialsBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }

    }

}