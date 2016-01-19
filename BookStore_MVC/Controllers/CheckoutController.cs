using BookStore_MVC.DAL;
using BookStore_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore_MVC.Controllers
{
    public class CheckoutController : Controller
    {
        BookContext storeDB = new BookContext();
        
        // GET: Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection form)
        {
            Order order = new Order();
            TryUpdateModel(order);

            try
            {
                order.OrderDate = DateTime.Now;

                // Save Order
                storeDB.Orders.Add(order);
                storeDB.SaveChanges();
                // Process order
                ShoppingCart cart = new ShoppingCart(this.HttpContext);
                cart.CreateOrder(order);
                return RedirectToAction("Complete", new { id = order.OrderId });
            }
            catch
            {
                return View(order);
            }
        }

        public ActionResult Complete(int id)
        {
            return View();
        }
    }
}