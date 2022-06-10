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
    public class CusWorkController : Controller
    {
        [IsLogged]
        public ActionResult DataView()
        {
            List<CusWork> times = CusWorkBLL.List().ToList();
            return View(times);
        }

        [IsLogged]
        public JsonResult Create(CusWork model)
        {
            if (CusWorkBLL.Add(model) != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { error = "error", msg = "Incorrect Info .. ! " }, JsonRequestBehavior.AllowGet);
            }
        }
        [IsLogged]
        public JsonResult Del(int Id)
        {
            if (Id > 1)
            {
                CusWorkBLL.Delete(Id);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }

    }
}