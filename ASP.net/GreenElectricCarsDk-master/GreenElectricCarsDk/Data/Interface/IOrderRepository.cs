using GreenElectricCarsDk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Data.Interface
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
