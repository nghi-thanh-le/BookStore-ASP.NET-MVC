using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore_MVC.Models;
using BookStore_MVC.DAL;
using System.Web.Mvc;

namespace BookStore_MVC.Models
{
    public class ShoppingCart
    {
        private BookContext storeDB = new BookContext();
        string ShoppingCartId { get; set; }

        public ShoppingCart(HttpContextBase context)
        {
            if (context.Session["CartId"] == null)
            {
                // Generate a new random GUID using System.Guid class
                Guid tempCartId = Guid.NewGuid();
                // Send tempCartId back to client as a cookie
                context.Session["CartId"] = tempCartId.ToString();
            }
            this.ShoppingCartId = context.Session["CartId"].ToString();
        }

        public void AddToCart(Book book)
        {
            // find the existing cart
            var cartItem = storeDB.Carts.SingleOrDefault(c => c.CartId == ShoppingCartId && c.BookIsbn == book.BookIsbn);

            // if there is no existing card in database
            // create a new one
            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    BookIsbn = book.BookIsbn,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                storeDB.Carts.Add(cartItem);
            } else
            // or increase the quantity of item in cart
            {
                cartItem.Count++;
            }
            storeDB.SaveChanges();
        }

        public void RemoveFromCart(string id)
        {
            // Get the cart
            var cartItem = storeDB.Carts.Single(cart => cart.CartId == ShoppingCartId && cart.BookIsbn == id);
            int itemCount = 0;

            if(cartItem != null)
            {
                if(cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                } else
                {
                    storeDB.Carts.Remove(cartItem);
                }
                storeDB.SaveChanges();
            }
        }

        public void EmptyCart()
        {
            var cartItems = storeDB.Carts.Where(cart => cart.CartId == ShoppingCartId);
            foreach(var cartItem in cartItems)
            {   
                storeDB.Carts.Remove(cartItem);
            }
            storeDB.SaveChanges();
        }

        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in storeDB.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }

        public decimal GetTotal()
        {
            // Multitply album price by count of that album to get
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total price
            decimal? total = (from cartItems in storeDB.Carts
                             where cartItems.CartId == ShoppingCartId
                             select (int?)cartItems.Count * cartItems.Book.BookPrice).Sum();
            return total ?? decimal.Zero;
        }

        public void CreateOrder(Order order)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItems();
            // Iterate over the items in the cart,
            // adding the order details for each
            foreach(var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    BookIsbn = item.BookIsbn,
                    OrderId = order.OrderId,
                    UnitPrice = item.Book.BookPrice,
                    Quantity = item.Count
                };

                // Set the order total of the shopping cart
                orderTotal += (item.Count * item.Book.BookPrice);

                storeDB.OrderDetails.Add(orderDetail);
            }

            // set the order's total to the orderTotal count
            order.Total = orderTotal;
            // save the order
            storeDB.SaveChanges();
            // Empty the shopping cart
            EmptyCart();
        }

        public List<Cart> GetCartItems()
        {
            return storeDB.Carts.Where(cart => cart.CartId == ShoppingCartId).ToList();
        }

        private string GetCartId(HttpContextBase context)
        {
            if (context.Session["CartId"] == null)
            {
                // Generate a new random GUID using System.Guid class
                Guid tempCartId = Guid.NewGuid();
                // Send tempCartId back to client as a cookie
                context.Session["CartId"] = tempCartId.ToString();
            }
            return context.Session["CartId"].ToString();
        }
    }
}