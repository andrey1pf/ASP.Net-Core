using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; } // return all products
        IEnumerable<Car> getFavCars { get; } // return favourits products
        Car getObjectCar(int carId); // retunt product with using id
    }
}
