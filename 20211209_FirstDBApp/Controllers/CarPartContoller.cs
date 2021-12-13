using _20211209_FirstDBApp.Models;
using _20211209_FirstDBApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211209_FirstDBApp.Controllers
{
    public class CarPartController : Controller
    {
        private CarsService _carService;
        private CarPartsService _carPartsService;
        public CarPartController(CarsService carService, CarPartsService carPartsService)
        {
            _carService = carService;
            _carPartsService = carPartsService;
        }

        public IActionResult Create(int Id)
        {
            CarPartAddModel m = new CarPartAddModel() { CarId = Id };
            return View(m);
        }

    }
}
