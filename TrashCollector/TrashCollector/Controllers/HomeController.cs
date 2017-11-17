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

        public ActionResult Calendar()
        {
            ViewBag.Message = "Your Calendar";
            
            return View();
        }

        //get
        public ActionResult GoogleMaps()
        {
            ViewBag.Message = "Google Maps";

            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GoogleMaps([Bind(Include = "CustomerID,FirstName,LastName,Address,ZipCode,PickUpDay")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var currentUser = User.Identity.Name;
                //customer.ZipCode = User.Identity.Name(customer.ZipCode);
                //var customerAddress = context.customers.Where(a => a.Address = )

            }
            return View();
        }



        public ActionResult PayPal()
        {
            ViewBag.Message = "PayPal";

            return View();
        }
    }
}