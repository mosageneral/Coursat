using Coursat.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coursat.Controllers
{
    [Authorize(Roles = "Admins")]
    public class RolesController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: RolesViewModel
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Roles .ToList ());
        }

        // GET: RolesViewModel/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RolesViewModel/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolesViewModel/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                db.Roles.Add(role);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            return View(role);
        }

        // GET: RolesViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RolesViewModel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RolesViewModel/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            var role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }

            return View(role);
        }

        // POST: RolesViewModel/Delete/5
        [HttpPost]
        public ActionResult Delete(IdentityRole Role)
        {
            try
            {
                // TODO: Add delete logic here
                var myrole = db.Roles.Find(Role.Id);
                db.Roles.Remove(myrole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Role);
            }
        }
    }
}
