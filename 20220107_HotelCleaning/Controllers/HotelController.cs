using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Models.Dtos;
using _20220107_HotelCleaning.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _20220107_HotelCleaning.Controllers
{
    public class HotelController : Controller
    {
        private readonly ILogger<HotelController> _logger;
        private readonly HotelService _hotelService;

        public HotelController(ILogger<HotelController> logger, HotelService hotelService)
        {
            _logger = logger;
            _hotelService = hotelService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            var hotels = _hotelService.GetAllNotDeleted();
            List<HotelDto> hotelDtos = new List<HotelDto>();
            foreach(var hotel in hotels)
            {
                hotelDtos.Add(HotelDtoMapper.MapToListDto(hotel));
            }
            return View(hotelDtos);
        }
        public IActionResult Details(int Id)
        {
            var hotel = _hotelService.Get(Id);
            return View(HotelDtoMapper.MapToDetailsDto(hotel));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
