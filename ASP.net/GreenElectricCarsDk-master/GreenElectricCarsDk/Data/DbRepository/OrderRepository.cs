using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Data.DbRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationDbContext dbContext, ShoppingCart shoppingCart)
        {
            _dbContext = dbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _dbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItemsList;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = item.Quantity,
                    OrderId = order.OrderId,
                    CarId = item.Car.CarId,
                    Price = item.Car.Price
                };
                _dbContext.OrderDetails.Add(orderDetail);
            }
            _dbContext.SaveChanges();
        }
    }
}
