using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FGCSerbiaWeb.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Tournaments()
        {
            ViewBag.Message = "Your tournaments page.";

            return View();
        }
        public ActionResult Twitch()
        {
            ViewBag.Message = "Your twitch page.";

            return View();
        }
        public ActionResult Meetups()
        {
            ViewBag.Message = "Your meetups page.";

            return View();
        }
    }
}