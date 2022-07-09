using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using Sales.Common;
using BLL;

namespace Sales.Controllers
{
    public class VacationTypesController : Controller
    {
        // GET: VacationTypes
        [IsLogged]
        [IsManager]
        public ActionResult Index()
        {
            ViewBag.Title = "Vacation Types Managment";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult DataView()
        {
            List<VacationTypes> Types = VacationTypesBLL.List().ToList();
            return View(Types);
        }
        [IsLogged]
        public ActionResult Select(int Id = 0)
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            List<VacationTypes> Types = VacationTypesBLL.List().ToList();
            return View(Types);
        }
        [IsLogged]
        public JsonResult Create(VacationTypes model)
        {
            if (VacationTypesBLL.Add(model) != 0)
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
            VacationTypesBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


    }
}