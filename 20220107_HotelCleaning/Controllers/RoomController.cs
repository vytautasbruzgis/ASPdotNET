using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Models.Dtos;
using _20220107_HotelCleaning.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Controllers
{
    public class RoomController : Controller
    {
        private HotelService _hotelService;
        private RoomService _roomService;
        private VisitorService _visitorService;
        private PersonService _personService;
        private BookingService _bookingService;
        public RoomController(
            HotelService hotelService, RoomService roomService, VisitorService visitorService, PersonService personService,
            BookingService bookingService
            )
        {
            _hotelService = hotelService;
            _roomService = roomService;
            _visitorService = visitorService;
            _personService = personService;
            _bookingService = bookingService;
        }
        public IActionResult Create(int? hotelId)
        {
            /* todo RoomFloor priklausomai nuo pasirinkto viešbučio */
            RoomCreateDto room = new RoomCreateDto();
            room.Floors = new List<int>();
            int maxFloors = hotelId.HasValue ? _hotelService.Get(hotelId.Value).FloorsCount : 10;
            for (int i = 0; i < 10; i++)
            {
                room.Floors.Add(i + 1);
            }
            room.HotelId = hotelId.HasValue ? hotelId.Value : 0;
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

        //public IActionResult BookRoom(int roomId)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BookRoom(roomId);
        //    }
        //    return RedirectToAction("Details", "Hotel", new { Id = 1});
        //}

        public IActionResult Book(int roomId, int? visitorId)
        {
            BookRoomDto roomBooking = new BookRoomDto();
            roomBooking.RoomId = roomId;
            roomBooking.room = _roomService.Get(roomId);
            if (visitorId.HasValue)
            {
                roomBooking.VisitorId = visitorId.Value;
                roomBooking.Visitor = _visitorService.Get(visitorId.Value);
            } else
            {
                roomBooking.Visitor = null;
            }
            roomBooking.Visitors = _visitorService.GetAllNotDeletedIncluded();
            return View(roomBooking);
        }
        [HttpPost]
        public IActionResult Book(BookRoomDto roomBooking)
        {
            if (!ModelState.IsValid)
            {
                return View(roomBooking);
            }

            Visitor roomVisitor = new Visitor();
            roomVisitor.Person = new Person()
            {
                FirstName = "Vytautas",
                LastName = "Bruzgis",
                CityId = 1
            };
            _personService.Create(roomVisitor.Person);
            _visitorService.Create(roomVisitor);
            Booking booking = new Booking();
            booking.VisitorId = roomVisitor.Id;
            //booking.RoomId = roomId;
            booking.Date = DateTime.Now.AddDays(1);
            _bookingService.Create(booking);
            return RedirectToAction("Details", "Hotel", new {Id = 1 /*hotelId*/ });
        }
    }
}
