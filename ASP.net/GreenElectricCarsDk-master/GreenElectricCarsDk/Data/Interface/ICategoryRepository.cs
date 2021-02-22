using GreenElectricCarsDk.Models;
using System.Collections.Generic;

namespace GreenElectricCarsDk.Data.Interface
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
    }
}
