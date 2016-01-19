using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore_MVC.Models;
using BookStore_MVC.ViewModel;
using BookStore_MVC.DAL;

namespace BookStore_MVC.Controllers
{
    public class ShoppingCartController : Controller
    {

        private BookContext storeDB = new BookContext();
        
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(this.HttpContext);
            // Set up our ViewModel

            var viewModel = new ShoppingCartViewModel
            {
               CartItems = cart.GetCartItems(),
               CartTotal = cart.GetTotal()
            };

            return View(viewModel);
        }

        // GET: /Store/AddToCart/5
        public ActionResult AddToCart(string id)
        {
            // find the book in db and get book , id must have value
            var bookInDB = storeDB.Books.Single(book => book.BookIsbn == id);

            // create cart object with this session
            ShoppingCart cart = new ShoppingCart(this.HttpContext);
            
            // Add it to the shopping cart
            cart.AddToCart(bookInDB);

            return RedirectToAction("Index");
        }
        
        public ActionResult RemoveFromCart(string id)
        {
            ShoppingCart cart = new ShoppingCart(this.HttpContext);

            // remove from cart
            cart.RemoveFromCart(id);

            return RedirectToAction("Index");
        }

        //
        // GET: /ShoppingCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            /*
            var cart = ShoppingCart.GetCart(this.HttpContext); 

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary"); */
            return View();
        }
    }
}