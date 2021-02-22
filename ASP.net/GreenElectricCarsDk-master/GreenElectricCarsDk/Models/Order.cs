using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Display(Name = "First Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public List<OrderDetail> OrderLines { get; set; }
    }
}
