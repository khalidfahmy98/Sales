using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;
using Sales.Common;

namespace Sales.Controllers
{
    public class HomeController : Controller
    {
        [IsLogged]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }
        [HttpPost]
        public JsonResult Authorize(ManEmp model)
        {
            ManEmp user = ManEmpBLL.Login(model.Username, model.Password);
            if (user != null)
            {
                if ( Convert.ToInt32(user.Status) == 1)
                {
                    Session["UserID"] = user.Id;
                    Session["Username"] = user.Username;
                    Session["Rule"] = user.Rule;
                    return Json(new { success = "success", link = "/" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { error = "error", msg = "Contact Support Your Account Blocked .. ! " }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { error = "error", msg = "Username Or Password Incorrect" }, JsonRequestBehavior.AllowGet);

            }
        }

        [IsLogged]
        public ActionResult Logout()
        {
            Session.Remove("UserID");
            Session.Remove("Username");
            Session.Remove("Rule");
            return View("Login");
        }
        [IsLogged]
        public ActionResult RuleError()
        {
            ViewBag.Title = " Rule Error";
            return View();
        }



    }
}