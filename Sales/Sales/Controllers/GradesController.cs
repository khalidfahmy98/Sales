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
    public class GradesController : Controller
    {   
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Grades Operations";
            return View();
        }
        [IsLogged]
        public ActionResult DataView()
        {
            List<Grades> grades = GradesBLL.List().ToList();
            return View(grades);
        }
        [IsLogged]
        public ActionResult Select(int Id = 0)
        {
            CustomerBridgeGrade customerGrade = CustomerBridgeGradeBLL.List().Where(e => e.CustomerId == Id).FirstOrDefault();
            int grade = customerGrade.Grades.Id;
            if (grade != 0)
            {
                ViewBag.Id = grade;
            }
            List<Grades> grades = GradesBLL.List().ToList();
            return View(grades);
        }
        [IsLogged]
        public JsonResult Edit(Grades model)
        {
            if (GradesBLL.Edit(model) )
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }

        [IsLogged]
        public JsonResult Create(Grades model)
        {
            if (GradesBLL.Add(model) != 0)
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
            GradesBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }

    }
}