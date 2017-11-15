using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        [OutputCache(Duration =60, VaryByParam ="none")]
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

        public ActionResult Calendar()
        {
            ViewBag.Message = "Your Calendar";

            return View();
        }

        public ActionResult GoogleMaps()
        {
            ViewBag.Message = "Google Maps";

            return View();
        }

        public ActionResult PayPal()
        {
            ViewBag.Message = "PayPal";

            return View();
        }
    }
}