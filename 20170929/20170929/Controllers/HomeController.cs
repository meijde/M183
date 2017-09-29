using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20170929.Controllers
{
    public class HomeController : Controller
    {
        //Client ID: 1085496039842-sa1i8enohstpjutiugp3cpltmin1pvb0.apps.googleusercontent.com 
        //Client Schlüssel:  WYhnz_DWSUk3Xx9t2u1ikTQR 

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult SSOTokenSignin()
        {
            return Json("");
        }
    }
}