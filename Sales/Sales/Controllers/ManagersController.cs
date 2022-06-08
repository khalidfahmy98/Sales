using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Common;

namespace Sales.Controllers
{
    public class ManagersController : Controller
    {
        [IsLogged]
        [IsManager]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Manager";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult Operations()
        {
            ViewBag.Title = "Managers Operations";
            return View();
        }
        [IsLogged]
        [IsManager]
        public JsonResult Create(ManEmp model)
        {
            if (ManEmpBLL.Add(model) != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Username Already Registered" }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        [IsManager]
        public JsonResult Del(int Id)
        {
            if (Id > 1)
            {
                ManEmpBLL.Delete(Id);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }

    }
}