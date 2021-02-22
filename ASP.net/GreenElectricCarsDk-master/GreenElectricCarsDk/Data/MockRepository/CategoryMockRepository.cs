using GreenElectricCarsDk.Data.Interface;
using GreenElectricCarsDk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Data.MockRepository
{
    public class CategoryMockRepository : ICategoryRepository
    {

        #region Instance Fields
        private IEnumerable<Category> _category;
        #endregion
       
        #region Properties
        public IEnumerable<Category> Categories 
        {
            get
            {
                _category = new List<Category>
                {
                    new Category
                    {
                        CategoryName ="EcoFriendly",CategoryDescription="Environmental friendly car"
                    },
                    new Category
                    {
                        CategoryName ="Non-EcoFriendly", CategoryDescription ="NonEnvironment friendly"
                    }

                };
                return _category;
            }           
        }
        #endregion
    }
}
