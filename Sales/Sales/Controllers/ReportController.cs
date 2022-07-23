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
    public class ReportController : Controller
    {
        [IsLogged]
        [IsManager]
        public ActionResult Index()
        {
            return View();
        }
        [IsLogged]
        public ActionResult Visit(int Id)
        {
            ViewBag.Title = "Visit Report";
            Scheduale plans = SchedualeBLL.List().Where(e => e.Id == Id).FirstOrDefault();
            return View(plans);
        }
        [IsLogged]
        public JsonResult Create(VisitReports model)
        {
            if (VisitReportsBLL.Add(model) != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public ActionResult Reports()
        {
            ViewBag.Title = "Submitted Reports";
            int UserId = Convert.ToInt32(Session["UserID"]);
            int Rule = Convert.ToInt32(Session["Rule"]);
            if (Rule == 1 || Rule == 2)
            {
                List<VisitReports> reports = VisitReportsBLL.List().Where(e => e.Scheduale.ManEmpId == UserId).ToList();
                return View(reports);
            }
            else
            {
                List<VisitReports> reports = VisitReportsBLL.List().ToList();
                return View(reports);
            }
        }


    }
}