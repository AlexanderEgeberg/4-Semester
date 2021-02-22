using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Data.DbRepository
{
    public class CarRepository : ICarRepository
    {
        private ApplicationDbContext _dbContext;
        public CarRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }      
        public IEnumerable<Car> Cars => _dbContext.Cars.Include(c => c.Category);
    }
}
