using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EbayMVC.Models;
using EbayMVC.ServiceReference2;

namespace EbayMVC.Controllers
{ 
    public class ProductController : Controller
    {
        private ProductsDBContext db = new ProductsDBContext();

        //
        // GET: /Product/

        public ViewResult Index()
        {
            
            List<Products> prodList = new List<Products> { };
            EbayClientClient c = new EbayClientClient();

            var result = c.ItemByCategory("117031").ToList();
            foreach (tblItem t in result)
            {
                Products p = new Products
                {
                    Id = t.item_id,
                    item_title = t.item_title,
                    gallery_url = t.gallery_url,
                    listing_url = t.listing_url,
                    tblCategory = t.item_category
                };
                prodList.Add(p);
            }
            
            return View(prodList);
        }

        //
        // GET: /Product/Details/5

        public ViewResult Details(string id)
        {
            Products products = db.Store.Find(id);
            return View(products);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                db.Store.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(products);
        }
        
        //
        // GET: /Product/Edit/5
 
        public ActionResult Edit(string id)
        {
            Products products = db.Store.Find(id);
            return View(products);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(Products products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        //
        // GET: /Product/Delete/5
 
        public ActionResult Delete(string id)
        {
            Products products = db.Store.Find(id);
            return View(products);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Products products = db.Store.Find(id);
            db.Store.Remove(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}