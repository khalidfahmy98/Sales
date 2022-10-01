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
    public class ReportingController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Day Report ";
            return View();
        }
        [IsLogged]
        public ActionResult Dataview(String Date)
        {
            DateTime datee = Convert.ToDateTime(Date);
            int UserId = Convert.ToInt32(Session["UserID"]);
            List<Scheduale> calls = SchedualeBLL.List().Where( e => e.VisitDate == datee && e.ManEmpId == UserId ).ToList();
            return View(calls);
        }
        [IsLogged]
        public JsonResult CreateHeader(ReportHeader model)
        {
            int UserId = Convert.ToInt32(Session["UserID"]);
            model.ManEmpId = UserId;
            int ReportHeaderId = ReportHeaderBLL.Add(model);
            if ( ReportHeaderId  != 0 )
            {
                return Json(new { status = "success", msg = ReportHeaderId }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult CreateCustomerBody(ReportCustomerBody model)
        {
            int ReportBodyCustomer = ReportCustomerBodyBLL.Add(model);
            if (ReportBodyCustomer != 0)
            {
                return Json(new { status = "success", msg = ReportBodyCustomer }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult CreateProductBody(ReportProductBody model)
        {
            int reportproduct = ReportProductBodyBLL.Add(model);
            if (reportproduct != 0)
            {
                return Json(new { status = "success", msg = reportproduct }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}