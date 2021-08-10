
using category.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace category.Controllers
{
    public class CatController : Controller
    {
        // GET: Cat
        db_testEntities dbobj = new db_testEntities();
        public ActionResult Cat(Category1 obj)
        {
            if (obj != null)
                return View(obj);
            else
                return View();

        }

        [HttpPost]
        public ActionResult Catpro(Category1 model)
        {
            Category1 obj = new Category1();
            if (ModelState.IsValid)
            {
                obj.CategoryId = model.CategoryId;
                obj.CategoryName = model.CategoryName;

                if (model.CategoryId == 0)
                {
                    dbobj.Category1.Add(obj);
                    dbobj.SaveChanges();
                }
                else
                {
                    dbobj.Entry(obj).State = EntityState.Modified;
                    dbobj.SaveChanges();
                }

            }
            ModelState.Clear();

            return View("Cat");
        }
       
        public ActionResult CatList()
        {
            var res = dbobj.Category1.ToList();
            return View(res);
        }
        public ActionResult Delete(int category_id)
        {
            var res = dbobj.Category1.Where(x => x.CategoryId == category_id).First();
            dbobj.Category1.Remove(res);
            dbobj.SaveChanges();
            var list = dbobj.Category1.ToList();

            return View("CatList", list);

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}