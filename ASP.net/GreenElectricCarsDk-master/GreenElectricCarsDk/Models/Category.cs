using GreenElectricCarsDk.Models;
using System.Collections.Generic;

namespace GreenElectricCarsDk.Models
{
    public class Category
    {
        // Primary key 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        // M - relationship 
        // one car has many categories such as Eco friendly Car or Non Eco Friendly Car
        public List<Car> Cars { get; set; }

    }
}
