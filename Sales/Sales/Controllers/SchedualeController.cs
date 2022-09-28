using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;
using Sales.Common;
using Sales.Models;

namespace Sales.Controllers
{
    public class SchedualeController : Controller
    {
        // GET: Scheduale
        [IsLogged]
        public ActionResult Index()
        {
            ViewBag.Title = "Employee Plans";
            return View();
        }
        [IsLogged]
        public ActionResult PlanView(int Emp , int Month , int Type )
        {
            List<Scheduale> scheduales = SchedualeBLL.List().Where( e=> e.ManEmpId == Emp && e.Month == Month && e.Customers.TypeId == Type ).ToList();
            return View(scheduales);
        }
        [IsLogged]
        public ActionResult Plan()
        {
            ViewBag.Title = "My Plans";
            return View();
        }
        [IsLogged]
        public ActionResult MyScheduales()
        {   
            ViewBag.Title = "Plans Management";
            return View();
        }
        [IsLogged]
        public ActionResult DataView(String Month)
        {
            int UserId = Convert.ToInt32(Session["UserId"]);
            int Rule = Convert.ToInt32(Session["Rule"]);
            int Leader = 1 ;
            if ( Rule == 1 || Rule == 2)
            {
                Leader = Convert.ToInt32(ManEmpBLL.Get(UserId).Lead);
            }
            ViewBag.leader = Leader;
            ViewBag.Monthh = Month;
            List<Customers> customers = CustomersBLL.List().ToList();
            List<ManEmp> manEmp = ManEmpBLL.List().ToList();
            List<EmpList> emplist = EmpListBLL.List().Where(e => e.EmployeeId == UserId).ToList();
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
        [IsLogged]
        public JsonResult Del(int Id)
        {
            SchedualeBLL.Delete(Id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        [IsLogged]
        public JsonResult UpdateStart(StartingPoints model)
        {
            int schedId = Convert.ToInt32(model.SchedualeId);
            Scheduale sched = SchedualeBLL.Get(schedId);
            sched.Start = 1;
            SchedualeBLL.Edit(sched);
            if ( StartingPointsBLL.List().Where(e =>  e.Month == model.Month && e.Day == model.Day).FirstOrDefault() == null)
            {
                if(StartingPointsBLL.Add(model) != 0)
                {
                    return Json("success", JsonRequestBehavior.AllowGet);
                }
            }
            return Json("error", JsonRequestBehavior.AllowGet);
        }


    }
}