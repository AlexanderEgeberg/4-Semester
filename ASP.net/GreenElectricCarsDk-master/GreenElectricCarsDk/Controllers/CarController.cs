using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using GreenElectricCarsDk.ViewModel;

namespace GreenElectricCarsDk.Controllers
{
    public class CarController : Controller
    {
        #region Instance Fields
        private ICarRepository _carRepo;
        private ICategoryRepository _categoryRepo;
        #endregion

        #region Properties
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentCategory { get; set; } = string.Empty;
        #endregion


        #region Constructor
        public CarController(ICarRepository carRepo , ICategoryRepository categoryRepo)
        {
            _carRepo = carRepo;
            _categoryRepo = categoryRepo;
        }
        #endregion

        public IActionResult GetCars(string category)
            {

            // if search category such as EcoFriendly and Non-EcoFriendly is empty 
            if (string.IsNullOrEmpty(category))
            {
                Cars = _carRepo.Cars.OrderBy(c => c.CarId);
                CurrentCategory = "All-Cars";
            }
            else
            {
                if (string.Equals("Eco-Friendly", category, StringComparison.OrdinalIgnoreCase))
                {
                    Cars = _carRepo.Cars.Where(c => c.Category.CategoryName.Equals("Eco-Friendly")).OrderBy(c => c.Name).ThenBy(c => c.Price);
                }
                else
                {
                    Cars = _carRepo.Cars.Where(c => c.Category.CategoryName.Equals("NonEco-Friendly")).OrderBy(c => c.Name).ThenBy(c => c.Price);
                }
                // here we assign the current category based on search equality
                CurrentCategory = category;
            }

            CarVm vm = new CarVm()
            {
                Cars = Cars,
                CurrentCategory = CurrentCategory
            };

            return View(vm);
        }   
    }
}
