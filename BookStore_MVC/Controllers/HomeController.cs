using BookStore_MVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore_MVC.Controllers
{
    public class HomeController : Controller
    {
        // connect to dabase
        private BookContext db = new BookContext();

        // Edit the main page
        public ActionResult Index()
        {
            // Select 4 latest book
            var latestFour = db.Books.OrderByDescending(b => b.BookIsbn).Take(4);
            return View(latestFour);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}