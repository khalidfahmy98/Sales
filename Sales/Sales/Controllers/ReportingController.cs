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
    }
}