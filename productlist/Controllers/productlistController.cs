using productlist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace productlist.Controllers
{
    public class productlistController : Controller
    {
        db_testEntities dbobj = new db_testEntities();

        // GET: productlist
        public ActionResult Index()
        {
            var res = dbobj.ProductList1.OrderBy.Where(x => x.ProductName).ToList();
            return View(res);
        }

        // GET: productlist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // POST: productlist/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: productlist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: productlist/Edit/5
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

        // GET: productlist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: productlist/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
