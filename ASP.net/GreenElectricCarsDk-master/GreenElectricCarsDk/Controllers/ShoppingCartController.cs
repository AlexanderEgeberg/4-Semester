using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using GreenElectricCarsDk.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Components
{
    public class ShoppingCartController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(ICarRepository carRepository, ShoppingCart shoppingCart)
        {
            _carRepository = carRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult GetItems()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItemsList = items;
            var sCVM = new ShoppingCartVm
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int carId)
        {
            var selectedCar = _carRepository.Cars.FirstOrDefault(c => c.CarId == carId);
            if (selectedCar != null)
            {
                _shoppingCart.AddToCart(selectedCar);
            }

            return RedirectToAction("GetItems");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int carId)
        {
            var selectedCar = _carRepository.Cars.FirstOrDefault(c => c.CarId == carId);
            if (selectedCar != null)
            {
                _shoppingCart.RemoveFromCart(selectedCar);
            }

            return RedirectToAction("GetItems");
        }

    }
}
