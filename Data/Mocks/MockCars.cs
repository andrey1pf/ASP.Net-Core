using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla Model S",
                        shortDesc = "Love of all life.",
                        longDesc = "With the longest range and quickest acceleration of any electric vehicle in production.",
                        img = "/img/TeslaModelS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "Tesla Model X",
                        shortDesc = "Her forms drive me crazy.",
                        longDesc = "With the most power and quickest acceleration of any SUV, Model X Plaid is the highest performing SUV ever built.",
                        img = "/img/TeslaModelX.jpg",
                        price = 30000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "Ford Mustang 1970",
                        shortDesc = "Back to the Future.",
                        longDesc = "Classic American muscle car - the perfect solution for the soul.",
                        img = "/img/mustang.jpg",
                        price = 32000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                    new Car
                    {
                        name = "Mercedes-Benz s63",
                        shortDesc = "Sonic endorphin machine.",
                        longDesc = "The interior of this car has been developed over the years for your comfort.",
                        img = "/img/MBS63.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }

    }
}
