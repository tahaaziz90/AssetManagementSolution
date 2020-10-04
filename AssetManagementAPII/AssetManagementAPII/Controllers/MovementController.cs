using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetManagementAPII.Controllers
{
    public class MovementController : Controller
    {
        // GET: Movement
        public ActionResult SingleMovement()
        {
            return View();
        }

        public ActionResult BulkMovement()
        {
            return View();
        }
    }
}