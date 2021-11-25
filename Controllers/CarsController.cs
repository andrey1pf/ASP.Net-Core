using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class A { }

    
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List(A a) {
            ViewBag.Title = "Chest-auto";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.carCategory = "Top Cars";
            return View(obj);
        }
    }
}
