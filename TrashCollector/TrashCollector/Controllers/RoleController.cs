﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using TrashCollector.Models;

//namespace TrashCollector.Controllers
//{
//    public class RoleController : Controller
//    {
//        ApplicationDbContext context = new ApplicationDbContext();
//        // GET: Role
//        public ActionResult Index()
//        {
//            if (User.Identity.IsAuthenticated)
//            {
//                if (!isAdminUser())
//                {
//                    return RedirectToAction("Index", "Home");
//                }
//            }
//            else
//            {
//                return RedirectToAction("Index", "Home");
//            }
//            var Roles = context.Roles.ToList();
//            return View(Roles);
//        }
//    }
//}