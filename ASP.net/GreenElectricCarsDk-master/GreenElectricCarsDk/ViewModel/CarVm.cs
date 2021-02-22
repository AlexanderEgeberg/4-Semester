using GreenElectricCarsDk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.ViewModel
{
    public class CarVm
    {
        public IEnumerable<Car> Cars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
