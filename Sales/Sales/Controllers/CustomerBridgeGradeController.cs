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
            int userId = Convert.ToInt32(Session["UserID"]);
            List<CustomerBridgeGrade> bridge = CustomerBridgeGradeBLL.List().Where(e => e.ManEmpId == userId).ToList();
            return View(bridge);
        }
        [IsLogged]
        public JsonResult Create(CustomerBridgeGrade model)
        {
            CustomerBridgeGrade grade = new CustomerBridgeGrade();
            int userId = Convert.ToInt32(Session["UserID"]);
            grade = CustomerBridgeGradeBLL.List().Where(e => e.CustomerId == model.CustomerId && e.ManEmpId == userId).FirstOrDefault();
            if (grade == null) {
                if (CustomerBridgeGradeBLL.Add(model) != 0)
                {
                    return Json("success", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { error = "error", msg = "Already Assigned Grade For This Customer " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult CreateListed(CustomerBridgeGrade model) { 
            CustomerBridgeGrade ValidateGradeit = CustomerBridgeGradeBLL.List().Where(e => e.CustomerId == model.CustomerId && e.ManEmpId == model.ManEmpId).FirstOrDefault();
            if(ValidateGradeit != null)
            {
                ValidateGradeit.GradeId = model.GradeId;
                CustomerBridgeGradeBLL.Edit(ValidateGradeit);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                model.Leader = ManEmpBLL.Get(Convert.ToInt32(model.ManEmpId)).Lead;
                if (CustomerBridgeGradeBLL.Add(model) != 0)
                {
                    return Json("success", JsonRequestBehavior.AllowGet);
                }else{ 
                return Json(new { error = "error", msg = "Incorrect Information .. ! " }, JsonRequestBehavior.AllowGet);
                }
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