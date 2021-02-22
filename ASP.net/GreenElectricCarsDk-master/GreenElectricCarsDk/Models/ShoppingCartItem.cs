using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Car Car { get; set; }
        public int Quantity { get; set; }
        // Foreign key
        public string ShoppingCartId { get; set; }

    }
}
