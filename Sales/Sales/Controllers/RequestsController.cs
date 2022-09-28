using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Common;
using BLL;
using Entity;
using Sales.Models;

namespace Sales.Controllers
{
    public class RequestsController : Controller
    {
        [IsLogged]
        [IsManager]
        public ActionResult Index()
        {
            ViewBag.Title = "Account Requests";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult DataView()
        {
            List<ManEmp> Requests = ManEmpBLL.List().Where(e => e.Status == 0 && e.Rule != 0).ToList();
            return View(Requests);
        }
        [IsLogged]
        [IsManager]
        public JsonResult Approve(int Id)
        {
            ManEmp model = ManEmpBLL.Get(Id);
            model.Status = 1;
            ManEmpBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        [IsLogged]
        [IsManager]
        public ActionResult ListRequests()
        {
            ViewBag.Title = "Employee List Requests";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult ListRequestsView()
        {
            int Leader = Convert.ToInt32(Session["UserID"]);
            List<Customers> customers = CustomersBLL.List().ToList();
            List<ManEmp> manEmp = ManEmpBLL.List().Where(e => e.Lead == Leader).ToList();
            List<EmpList> emplist = EmpListBLL.List().Where(e => e.Status == 0).ToList();
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
        [IsManager]
        public JsonResult ApproveList(int Id)
        {
            EmpList model = EmpListBLL.Get(Id);
            model.Status = 1;
            EmpListBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        [IsLogged]
        [IsManager]
        public ActionResult GradeRequests()
        {
            ViewBag.Title = "Grade Requests";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult GradeDataview()
        {
            int Leader = Convert.ToInt32(Session["UserID"]);
            List<Customers> customers = CustomersBLL.List().ToList();
            List<ManEmp> manEmp = ManEmpBLL.List().Where(e => e.Lead == Leader).ToList();
            List<Grades> grades = GradesBLL.List().ToList();
            List<CustomerBridgeGrade> customerBridgeGrade = CustomerBridgeGradeBLL.List().Where(e => e.Status == 0).ToList();
            using (SalesEntities db = new SalesEntities())
            {
                var GradeRecords = from e in customerBridgeGrade
                                   join d in customers on e.CustomerId equals d.Id into table1
                                   from d in table1.ToList()
                                   join i in manEmp on e.ManEmpId equals i.Id into table2
                                   from i in table2.ToList()
                                   join c in grades on e.GradeId equals c.Id into table3
                                   from c in table3.ToList()
                                   select new CustomerGradeBridgeModel
                                   {
                                       customerBridgeGrade = e,
                                       customers = d,
                                       manEmp = i,
                                       grades = c
                                   };
                return View(GradeRecords);
            }

        }
        [IsLogged]
        [IsManager]
        public JsonResult ApproveGrade(int Id)
        {
            CustomerBridgeGrade model = CustomerBridgeGradeBLL.Get(Id);
            model.Status = 1;
            CustomerBridgeGradeBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        [IsLogged]
        [IsManager]
        public ActionResult VacationRequests()
        {
            ViewBag.Title = "Vacation Requests";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult VacationDateView()
        {
            int Leader = Convert.ToInt32(Session["UserID"]);
            List<Vacations> vacations = VacationsBLL.List().Where(e => e.Leader == Leader && e.Status == 0).ToList();
            return View(vacations);
        }
        [IsLogged]
        [IsManager]
        public JsonResult ApproveVacation(int Id)
        {
            Vacations model = VacationsBLL.Get(Id);
            model.Status = 1;
            VacationsBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        [IsLogged]
        [IsManager]
        public ActionResult PlanRequest()
        {
            ViewBag.Title = "Plan Requests";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult PlanDataview(String Id , String Month)
        {
            int Leader = Convert.ToInt32(Session["UserID"]);
            int Emp = Convert.ToInt32(Id);
            int MontP = Convert.ToInt32(Month);
            List<Scheduale> plans = SchedualeBLL.List().Where(e => e.Leader == Leader && e.Status == 0 && e.ManEmpId == Emp && e.Month == MontP).ToList();
            return View(plans);
        }
        [IsLogged]
        [IsManager]
        public JsonResult ApprovePlan(String Id)
        {
            int PlanR = Convert.ToInt32(Id);
            Scheduale model = SchedualeBLL.Get(PlanR);
            model.Status = 1;
            SchedualeBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        [IsLogged]
        [IsManager]
        public ActionResult CustomersRequests()
        {
            ViewBag.Title = "Customers Requests";
            return View();
        }
        [IsLogged]
        [IsManager]
        public ActionResult CustomersView()
        {
            int User = Convert.ToInt32(Session["UserID"]);
            int Lead = Convert.ToInt32(ManEmpBLL.Get(User).Lead);
            List<Customers> custms = CustomersBLL.List().Where(e => e.Status == null && e.ManEmp.Lead == Lead ).ToList();
            return View(custms);
        }
        [IsLogged]
        [IsManager]
        public JsonResult ApproveCustomer(int Id)
        {
            Customers model = CustomersBLL.Get(Id);
            model.Status = 1;
            CustomersBLL.Edit(model);
            return Json("success", JsonRequestBehavior.AllowGet);
        }

    }
}