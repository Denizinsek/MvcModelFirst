using DataExtractionLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataExtractionLogin.Controllers
{
    public class ProductsController : Controller
    {
        MvcModelFirstEntities db = new MvcModelFirstEntities();
        // GET: Products

        // Product List
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // Product Save
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Products products)
        {
            db.Products.Add(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}