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
    public class SchedualeController : Controller
    {
        // GET: Scheduale
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Employee Plans";
            return View();
        }
        [IsLogged]
        public ActionResult PlanView(int Emp , int Month)
        {
            List<Scheduale> scheduales = SchedualeBLL.List().Where( e=> e.ManEmpId == Emp && e.Month == Month).ToList();
            return View(scheduales);
        }

        [IsLogged]
        public ActionResult MyScheduales()
        {   
            ViewBag.Title = "My Sales Scheduales";
            return View();
        }
        [IsLogged]
        public ActionResult DataView()
        {
            int UserId = Convert.ToInt32(Session["UserId"]);
            List<Scheduale> scheduale = SchedualeBLL.List().Where(e => e.ManEmpId == UserId).ToList();
            return View(scheduale);
        }
        [IsLogged]
        public JsonResult Create(Scheduale model)
        {
            if (SchedualeBLL.Add(model) != 0)
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
            SchedualeBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


    }
}