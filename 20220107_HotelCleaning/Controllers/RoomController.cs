using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Models.Dtos;
using _20220107_HotelCleaning.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20220107_HotelCleaning.Controllers
{
    public class RoomController : Controller
    {
        private HotelService _hotelService;
        private RoomService _roomService;
        public RoomController(HotelService hotelService, RoomService roomService)
        {
            _hotelService = hotelService;
            _roomService = roomService;
        }
        public IActionResult Create(int? hotelId)
        {
            /* todo RoomFloor priklausomai nuo pasirinkto viešbučio */
            RoomCreateDto room = new RoomCreateDto(10);
            room.HotelId = (int)hotelId;
            room.Hotels = _hotelService.GetAllNotFilled();
            return View(room);
        }
        [HttpPost]
        public IActionResult Create(RoomCreateDto roomCreate) {

            if (!ModelState.IsValid)
            {
                return View(roomCreate);
            }
            Room room = RoomDtoMapper.MapToRoom(roomCreate);
            _roomService.Create(room);
            return RedirectToAction("Details", "Hotel", new { Id = roomCreate.HotelId});
        }
    }
}
