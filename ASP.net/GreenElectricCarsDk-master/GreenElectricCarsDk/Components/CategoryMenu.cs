using GreenElectricCarsDk.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GreenElectricCarsDk.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryMenu(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepo.Categories.OrderBy(n => n.CategoryName);
            return View(categories);
        }

    }
}
