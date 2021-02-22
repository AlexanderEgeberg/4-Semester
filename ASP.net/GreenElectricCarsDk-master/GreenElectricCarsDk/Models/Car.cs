using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Models
{
    public class Car
    {
        // primary key
        public int CarId { get; set; }
        public string Name { get; set; }
        public string ShortDescribtion { get; set; }
        public string LongDescription { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredCar { get; set; }
        public int Stock { get; set; }  
        
        public int Price { get; set; }
        
        // 1 - M relationship
        public virtual Category Category { get; set; }
        // Foreign key  
        public int CategoryId { get; set; }

    }
}
