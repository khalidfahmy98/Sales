using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;

namespace Sales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Authorize(Admins model)
        {
            Admins admin = BLL.ManEmp.Login(model.Username, model.Password);
            if (admin != null)
            {
                Session["UserID"] = admin.Id;
                Session["Username"] = admin.Username;
                Session["Rule"] = admin.Permission;
                return Json(new { success = "success", link = "/" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Username Or Password Incorrect" }, JsonRequestBehavior.AllowGet);

            }
        }


    }
}