using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetManagementAPII.Controllers
{
    public class AssetController : Controller
    {
        // GET: Asset
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult PrepareReverification()
        {
            return View();
        }

        public ActionResult AssetReverificationStatus()
        {
            return View();
        }

        public ActionResult ManageAsset()
        {
            return View();
        }


    }
}