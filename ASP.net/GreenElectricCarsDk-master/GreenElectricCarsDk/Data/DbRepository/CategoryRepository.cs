using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Data.DbRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Category> Categories => _dbContext.Categories;
    }
}
