﻿using Coursat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coursat.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            return View(db.Categories .ToList ());
        }
        [Authorize]
        public ActionResult Chat()
        {
            return View("ChatView");
        }
        [HttpPost]
        public ActionResult Search(string searchName)
        {
            var result = db.Courses.Where(a => a.Name.Contains(searchName)
             || a.Description.Contains(searchName)
             || a.Category.Name.Contains(searchName)
            ).ToList ();

            return View(result);
        }
        [Authorize]
        public ActionResult Indexcours(int courseid)
        {
            var coursee = db.Courses.Find(courseid);


            return View(coursee.videos.ToList());
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
    }
}