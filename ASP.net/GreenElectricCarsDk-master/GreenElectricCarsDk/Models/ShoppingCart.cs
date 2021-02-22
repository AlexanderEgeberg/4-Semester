using GreenElectricCarsDk.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenElectricCarsDk.Models
{
    public class ShoppingCart
    {
        // Primary key ......
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItemsList { get; set; }

        private ApplicationDbContext _dbContext;
        public ShoppingCart(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GetCart Method with parameter IService Provider 
        // Before adding this method we need to add three DLLs via Package console 
        // 1- Microsoft.Extension.Caching.Memory
        // 2- Microsoft.ASPNetCore.Session
        // 3- Microsoft.ASPNetCore.Http.Extensions
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            // Get current session object
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            // Get the currrent dbcontext
            var dbContext = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();
            session.SetString("cartId", cartId);
            return new ShoppingCart(dbContext) { ShoppingCartId = cartId };

        }

        // Add new Car with amount 

        public void AddToCart(Car car)
        {
            var shoppingCartItem = _dbContext.ShoppingCartItems.SingleOrDefault(s => s.Car.CarId == car.CarId && s.ShoppingCartId == ShoppingCartId);
            // check if shoppingCartItem is null then add by default values in cart
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Car = car,
                    Quantity = 1
                };

                // add shopping cart item into Database
                _dbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            // save the DB
            _dbContext.SaveChanges();
        }
        // Remove the Car 
        public int RemoveFromCart(Car car)
        {
            var shoppingCartItem = _dbContext.ShoppingCartItems.SingleOrDefault(s => s.Car.CarId == car.CarId && s.ShoppingCartId == ShoppingCartId);
            // check if shoppingCartItem is null 
            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localAmount = shoppingCartItem.Quantity;

                }
                else
                {
                    _dbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            // save the DB
            _dbContext.SaveChanges();
            return localAmount;
        }
        // Get all shopping cart Item
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItemsList ?? (ShoppingCartItemsList =
                _dbContext.ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Car)
                .ToList());
        }
        public void ClearCart()
        {
            var cartItems = _dbContext.ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _dbContext.ShoppingCartItems.RemoveRange(cartItems);
            _dbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _dbContext.ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId)
                .Select(cart => cart.Car.Price * cart.Quantity)
                .Sum();
            return total;
        }

    }
}
