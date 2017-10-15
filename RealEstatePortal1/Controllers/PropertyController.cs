using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstatePortal1.Controllers
{
    public class PropertyController : Controller
    {
        // GET: Property
        public ActionResult BuySaleRent()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }

    }
}