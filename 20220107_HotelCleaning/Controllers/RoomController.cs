using _20220107_HotelCleaning.Models.Dtos;
using _20220107_HotelCleaning.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20220107_HotelCleaning.Controllers
{
    public class RoomController : Controller
    {
        private HotelService _hotelService;
        public RoomController(HotelService hotelService)
        {
            _hotelService = hotelService;
        }
        public IActionResult Create(int? hotelId)
        {

            RoomCreateDto room = new RoomCreateDto();
            room.HotelId = hotelId;
            room.Hotels = _hotelService.GetAllNotDeleted();
            return View(room);
        }
    }
}
