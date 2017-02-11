using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelReviewProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "People have reviewed some hotels, restaurants, nightlife, and several other activities in different locations. We have assembled them.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact Humble Travel Reviews:";

            return View();
        }
    }
}