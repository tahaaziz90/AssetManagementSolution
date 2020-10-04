using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SharedModel;
using Model;
using System.Web;


namespace AssetManagementAPII.Controllers.API
{
   
    public class AuthenticateController : ApiController
    {
        //[HttpPost]
        //public string Login(Authentication login)
        //{

        //    using (AssetManagementEntities entities = new AssetManagementEntities())
        //    {

        //        var authenticate = entities.UserAuthentication(login.username, login.password);
        //        string data = authenticate.FirstOrDefault();
        //        if (data != "User not found !")
        //        {
        //            //HttpContext.Session["username"] = data;
        //            ////HttpContext.Current.Session.Add("__MySessionObject", data);
                    
                    
        //            return data;
        //        }
        //        else
        //        {
        //            return "Login Unsuccessful";
        //        }
        //    }

        //}

    }
}
