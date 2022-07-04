using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Common;
using BLL;
using Entity;

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

    }
}