using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.Services;
using String = System.String;

namespace Pizza_StoreV1.Controllers
{
    public class PizzaController : Controller
    {
        private PizzaCatalog _pizzaCatalog;

        public PizzaController(PizzaCatalog pizzaCatalog)
        {
            _pizzaCatalog = pizzaCatalog;
        }
        public IActionResult Index(string searchCriteria)
        {
            var pizzas = _pizzaCatalog.AllPizzas();
            if (!String.IsNullOrEmpty(searchCriteria))
            {
                pizzas = _pizzaCatalog.FilterName(searchCriteria);
            }

            return View(pizzas);
        }
        public IActionResult IndexCreate()
        {
            return View(nameof(Create));
        }

        public IActionResult Create(Pizza pizza)
        {
            try
            {    // if model state property is valid then we create new student succesfully           
                if (ModelState.IsValid)
                {
                    _pizzaCatalog.AddStudent(pizza);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Create", "Unable to Create new Student: " + ex);
            }

            return View(pizza);
        }
    }
}
