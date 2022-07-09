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
            using (db_a89910_salesEntities db = new db_a89910_salesEntities())
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



    }
}