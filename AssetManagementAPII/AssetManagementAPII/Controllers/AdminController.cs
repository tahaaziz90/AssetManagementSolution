using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetManagementAPII.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult ManageUser()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Login", "Login/Index");
            }
            else
            {
                ViewBag.Title = "User Page";

                return View();
            }
        }

        public ActionResult ManageCompany()
        {
            return View();
        }

        public ActionResult ManageBranch()
        {
            return View();
        }

        public ActionResult ManageLocation()
        {
            return View();
        }

        public ActionResult ManageCategory()
        {
            return View();
        }

        public ActionResult ManagePasswords()
        {
            return View();
        }
        
    }
}