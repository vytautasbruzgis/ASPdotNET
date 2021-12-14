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
            CarPartModel m = new CarPartModel() { CarId = Id };
            return View(m);
        }
        [HttpPost]
        public IActionResult Create(CarPartModel model)
        {
            _carPartsService.Create(model);
            return RedirectToAction("Details", "Car", new { id = model.CarId });
        }

        public IActionResult Delete(int id, int carId)
        {
            
            _carPartsService.Delete(id);
            return RedirectToAction("Details", "Car", new { id = carId});
        }

    }
}
