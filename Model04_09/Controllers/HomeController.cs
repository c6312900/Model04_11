using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model04_09.DAL;
using Model04_09.Models;

namespace Model04_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductByID(int Id)
        {
            //NorthwindEntities db = new NorthwindEntities();
            //var query = from p in db.Products
            //            where p.ProductID == Id
            //            select p;

            //var result = query.First(); 
            //return View(result);
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductID(Id);
            return View(result);
        }

        public ActionResult ProductsByCategory(int Id)
        {
            //NorthwindEntities db = new NorthwindEntities();
            //var query = from p in db.Products
            //            where p.CategoryID == Id
            //            select p;

            //var result = query.ToList();
            //return View(result);
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductsByCategoryID(Id);
            return View(result);
        }

    }
}