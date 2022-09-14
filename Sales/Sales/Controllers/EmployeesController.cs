using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Entity;
using Sales.Common;
using Sales.Models;

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
        public ActionResult Review()
        {
            ViewBag.Title = "Review Employee List";
            return View();
        }
        [IsLogged]
        public ActionResult ReviewDataview(String Id  , String typ)
        {
            // getting data from bridge requires inner join 
            int Employee = Convert.ToInt32(Id);
            int CustomerType = Convert.ToInt32(typ);
            List<Customers> customers = CustomersBLL.List().Where( e => e.TypeId == CustomerType).ToList();
            List<ManEmp> manEmp = ManEmpBLL.List().ToList();
            List<EmpList> emplist = EmpListBLL.List().Where(e => e.EmployeeId == Employee  ).ToList();
            using (SalesEntities db = new SalesEntities())
            {
                var employeeRecord = from e in emplist
                                     join d in customers on e.CustomerId equals d.Id into table1
                                     from d in table1.ToList()
                                     join i in manEmp on e.EmployeeId equals i.Id into table2
                                     from i in table2.ToList()
                                     select new EmpListModel
                                     {
                                         emplist = e,
                                         customers = d,
                                         manEmp = i
                                     };
                return View(employeeRecord);
            }
        }
        [IsLogged]
        public ActionResult ListDataview(String Id , String Spec , String typ)
        {
            int Area = Convert.ToInt32(Id);
            int special = Convert.ToInt32(Spec);
            int type = Convert.ToInt32(typ);
            List<Customers> customers = CustomersBLL.List().Where(e => e.AreaId == Area && e.SpecialId == special ).ToList();
            return View(customers);
        }
        [IsLogged]
        public JsonResult CreateList(EmpList model)
        {
            var checkListed = EmpListBLL.List().Where(e => e.CustomerId == model.CustomerId && e.EmployeeId == model.EmployeeId).FirstOrDefault();
            if ( checkListed == null  && model.CustomerId != null && model.EmployeeId != null )
            {   
                EmpListBLL.Add(model);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = " Customer Already Linked With This Employee .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public ActionResult Select(int Id = 0)
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            int Lead = Convert.ToInt32(Session["UserID"]);
            List<ManEmp> ManEmps = null;
            if ( Convert.ToInt32(Session["Rule"]) == 0)
            {
                 ManEmps = ManEmpBLL.List().Where(e => e.Rule > 0 && e.Status == 1).ToList();
            }
            else
            {
                ManEmps = ManEmpBLL.List().Where(e => e.Lead == Lead && e.Status == 1).ToList();
            }
            return View(ManEmps);
        }
        [IsLogged]
        public ActionResult SelectLeaders(int Id = 0)
        {
            if (Id != 0)
            {
                ViewBag.Id = Id;
            }
            List<ManEmp> ManEmps = ManEmpBLL.List().Where(e => e.Rule ==  2 ||  e.Rule == 0).ToList();
            return View(ManEmps);
        }
        [IsLogged]
        [IsManager]
        public ActionResult Operations()
        {
            List<ManEmp> employees = ManEmpBLL.List().Where(e => e.Status == 1 && e.Id != 1).ToList();
            ViewBag.Title = " Employee Operations";
            return View(employees);
        }
        [IsLogged]
        [IsManager]
        public ActionResult LeadEmps()
        {
            int Leader = Convert.ToInt32(Session["UserID"]);
            List<ManEmp> employees = ManEmpBLL.List().Where(e => e.Lead == Leader ).ToList();
            ViewBag.Title = "My Employees";
            return View(employees);
        }
        [IsLogged]
        [IsManager]
        public JsonResult Create(ManEmp model)
        {
            model.Lead = Convert.ToInt32(Session["UserID"]);
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
        [IsLogged]
        public JsonResult DelCus(int Id)
        {
            if (Id > 1)
            {
                EmpListBLL.Delete(Id);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult Leading(int Emp , int Leader)
        {
            ManEmp model = ManEmpBLL.Get(Emp);
            model.Lead = Leader;
            ManEmpBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


    }
}