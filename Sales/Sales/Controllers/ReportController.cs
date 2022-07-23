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
            return View();
        }
        [IsLogged]
        public JsonResult Create(Scheduale model)
        {
            int UserId = Convert.ToInt32(Session["UserID"]);
            int Leader = Convert.ToInt32(ManEmpBLL.Get(UserId).Lead);
            model.Leader = Leader;
            if (SchedualeBLL.Add(model) != 0)
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