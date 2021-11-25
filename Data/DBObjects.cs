using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) {
            

            if (!content.Category.Any()) // check for null
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Love of all life.",
                        longDesc = "With the longest range and quickest acceleration of any electric vehicle in production.",
                        img = "/img/TeslaModelS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Автомобили с ДВС"]
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
                        Category = Categories["Автомобили с ДВС"]
                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Электромобили", desc = "Инновационный и экологический вид транспорта"},
                        new Category{ categoryName = "Автомобили с ДВС", desc = "Классический вид транспорта"}
                    };

                    category = new Dictionary<string, Category>();
                    // add element from list
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
