using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Common;
using Entity;
using BLL;

namespace Sales.Controllers
{
    public class VacationsController : Controller
    {
        // GET: Vacations
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Vacation & Activites";
            return View();
        }
        [IsLogged]
        public ActionResult DataView()
        {
            // no problem to get id from session cuz already who can create is MR or DM 
            int User = Convert.ToInt32(Session["UserID"]);
            List<Vacations> vacations = VacationsBLL.List().Where(e => e.EmployeeId == User).ToList();
            return View(vacations);
        }
        [IsLogged]
        public JsonResult Create(Vacations model)
        {
            model.EmployeeId = Convert.ToInt32(Session["UserID"]);
            model.Leader = ManEmpBLL.Get(Convert.ToInt32(Session["UserID"])).Lead;
            if (VacationsBLL.Add(model) != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}