using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetManagementAPII.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if (Session["username"] != null)
            {
                ViewBag.Title = "Home Page";

                return View();
                
            }
            else
            {
                return RedirectToAction("Login", "Login/Index");
            }

            //ViewBag.Title = "Home Page";

            //return View();
        }
    }
}
