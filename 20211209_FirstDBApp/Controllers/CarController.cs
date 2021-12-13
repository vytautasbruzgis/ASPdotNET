using Microsoft.AspNetCore.Mvc;
using _20211209_FirstDBApp.Services;
using _20211209_FirstDBApp.Models;
using System.Collections.Generic;

namespace _20211209_FirstDBApp.Controllers
{
    public class CarController : Controller
    {
        private CarsService _carService;
        public CarController(CarsService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarList()
        {
            var cars = _carService.GetAll();
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarModel car)
        {
            _carService.Create(car);
            return RedirectToAction("CarList");
        }

        public IActionResult Details(int id)
        {
            CarWithPartsModel carInfo = _carService.GetWithPartsById(id);
            return View(carInfo);
        }
        public IActionResult Edit(int id)
        {
            var car = _carService.GetById(id);
            if (car == null)
            {
                return RedirectToAction("CarList");
            }
            return View(car);
        }
        [HttpPost]
        public IActionResult Edit(CarModel car)
        {
            _carService.Update(car);
            return RedirectToAction("CarList");
        }

        public IActionResult Delete(int? id)
        {
            _carService.Delete((int)id);
            return RedirectToAction("CarList");
        }
    }
}
