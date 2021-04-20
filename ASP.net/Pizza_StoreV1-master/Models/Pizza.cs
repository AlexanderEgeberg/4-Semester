using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV1.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required"), MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }

        public Pizza(int id, string name, string description, decimal price, string imageName)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageName = imageName;
        }

        public Pizza()
        {
            
        }
    }
}
