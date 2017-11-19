using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

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

        public ActionResult Customer()
        {
            ViewBag.Message = "Customer Page";

            return View();

        }

        public ActionResult Employee()
        {
            ViewBag.Message = "Employee Page";

            return View();
                
        }


        public ActionResult PayPal()
        {
            ViewBag.Message = "PayPal";

            return View();
        }
    }
}