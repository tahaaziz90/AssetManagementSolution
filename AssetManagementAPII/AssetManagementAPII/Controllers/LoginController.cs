using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharedModel;

namespace AssetManagementAPII.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                return RedirectToAction("Index", "Home/Index");
            }
            else
            {
                return View();
            }
            
        }
    
        public ActionResult Logout()
        {

            Session["username"] = null;
            return RedirectToAction("Index", "Login/Index");
        }

        public ActionResult Login(Authentication login)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {

                var authenticate = entities.UserAuthentication(login.username, login.password);
                string data = authenticate.FirstOrDefault();
                if (data != "User not found !")
                {
                    //HttpContext.Session["username"] = data;
                    ////HttpContext.Current.Session.Add("__MySessionObject", data);
                    Session["username"] = data;
                    return RedirectToAction("Index","Home");
                    //return Redirect(Request.UrlReferrer.ToString());


                }
                else
                {
                    //return RedirectToAction("Index", "Login/Index"); ;
                    return Redirect(Request.UrlReferrer.ToString());
                }
            }
        }
    }


}