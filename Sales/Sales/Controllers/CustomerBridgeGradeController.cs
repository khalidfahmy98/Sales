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
    public class CustomerBridgeGradeController : Controller
    {
        // GET: CustomerBridgeGrade
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "My Grades Management";
            return View();
        }
        [IsLogged]
        public ActionResult DataView()
        {

            return View();
        }
        [IsLogged]
        public JsonResult Create(CustomerBridgeGrade model)
        {
            if (CustomerBridgeGradeBLL.Add(model) != 0)
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
            CustomerBridgeGradeBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


    }
}