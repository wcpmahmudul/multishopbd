﻿using multishopbd.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace multishopbd.Controllers
{
    public class HomeController : Controller
    {
        private MShopBdContext db = new MShopBdContext();
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

        public ActionResult Search(string q)
        {
            var categories = db.Categories
            .Where(a => a.CategoryName.Contains(q))
            .Take(10);
            return View(categories);
        }
    }
}