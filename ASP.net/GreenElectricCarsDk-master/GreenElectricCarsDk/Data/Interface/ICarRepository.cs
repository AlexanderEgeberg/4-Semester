using GreenElectricCarsDk.Models;
using System.Collections.Generic;

namespace GreenElectricCarsDk.Data.Interface
{
    public interface ICarRepository
    {
        // Get all Cars
        IEnumerable<Car> Cars { get;}
       
    }
}
