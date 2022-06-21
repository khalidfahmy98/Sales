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
    public class EmployeesController : Controller
    {
        [IsLogged]
        [IsManager]
        public ActionResult Index()
        {
            ViewBag.Title = "Create Employee";
            return View();
        }
        [IsLogged]
        public ActionResult List()
        {
            ViewBag.Title = "Employee Customer List";
            return View();
        }
        [IsLogged]
        public ActionResult ListDataview(String Id)
        {
            int Area = Convert.ToInt32(Id);
            List<Customers> customers = CustomersBLL.List().Where(e => e.AreaId == Area).ToList();
            return View(customers);
        }
        [IsLogged]
        public ActionResult Select(int Id = 0)
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            List<ManEmp> ManEmps = ManEmpBLL.List().ToList();
            return View(ManEmps);
        }
        [IsLogged]
        [IsManager]
        public ActionResult Operations()
        {
            List<ManEmp> employees = ManEmpBLL.List().Where(e => e.Rule == 0).ToList();
            ViewBag.Title = " Employee Operations";
            return View(employees);
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