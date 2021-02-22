using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenElectricCarsDk.Data.MockRepository
{
    public class CarMockRepository : ICarRepository
    {
        #region Instance Fields
        private ICategoryRepository _categoryRepo;
        private IEnumerable<Car> _cars;
       
        #endregion
        #region Constructor 
        public CarMockRepository()
        {
            _categoryRepo = new CategoryMockRepository();
        }
        #endregion

        #region Properties
        public IEnumerable<Car> Cars {
            get
            {
                _cars = new List<Car>()
                {
                   new Car
                   {
                       Name = "Tesla Model 3",
                       Price = 200000,
                       IsPreferredCar =true,
                       Stock=1,
                       Category = _categoryRepo.Categories.First(),
                       ShortDescribtion="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                       LongDescription="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                       ImageUrl="https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                       ImageThumbnailUrl ="car1.jpg"
                   },
                   new Car
                   {
                       Name = "Tesla Model 4",
                       Price = 200000,
                       IsPreferredCar =true,
                       Stock=1,
                       Category = _categoryRepo.Categories.First(),
                       ShortDescribtion="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                       LongDescription="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                       ImageUrl="https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                       ImageThumbnailUrl ="car2.jpg" 
                   },
                    new Car
                   {
                       Name = "Toyata",
                       Price = 500000,
                       IsPreferredCar =true,
                       Stock=1,
                       Category = _categoryRepo.Categories.Last(),
                       ShortDescribtion="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                       LongDescription="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                       ImageUrl="https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                       ImageThumbnailUrl ="car3.jpg"                   },
                     new Car
                   {
                       Name = "Mitsubishi Outlander PHEV",
                       Price = 500000,
                       IsPreferredCar =true,
                       Stock=1,
                       Category = _categoryRepo.Categories.Last(),
                       ShortDescribtion="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                       LongDescription="The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                       ImageUrl="https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                       ImageThumbnailUrl ="car4.jpg"                   }
                };
                return _cars;
            }
        }
           
        #endregion
    }
}
