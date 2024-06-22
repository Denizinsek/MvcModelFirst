using DataExtractionLogin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataExtractionLogin.Controllers
{
    public class AdminController : Controller
    {
        MvcModelFirstEntities db = new MvcModelFirstEntities();
        // GET: Admin

        
        // Admin index page
        public ActionResult Index()
        {
            return View();
        }

        // User Listing
        public ActionResult Users()
        {

            return View(db.Users.ToList());
        }

        // User Save

        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Users users)
        {
            db.Users.Add(users);
            db.SaveChanges();
            return RedirectToAction("Users");
        }

        // User update

        public ActionResult Update(int id)
        {
            var update = db.Users.Where(x => x.Id == id).FirstOrDefault();
            return View(update);
        }
        [HttpPost]
        public ActionResult Update(int id, Users users)
        {
            db.Users.AddOrUpdate(users);
            db.SaveChanges();
            return RedirectToAction("Users");
        }

        // User Delete

        public ActionResult Delete(int id)
        {
            var delete = db.Users.Where(x => x.Id == id).FirstOrDefault();
            db.Users.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Users");
        }


    }
}