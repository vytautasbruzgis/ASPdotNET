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
        private CityService _cityService;
        public RoomController(
            HotelService hotelService, RoomService roomService, VisitorService visitorService, PersonService personService,
            BookingService bookingService, CityService cityService
            )
        {
            _hotelService = hotelService;
            _roomService = roomService;
            _visitorService = visitorService;
            _personService = personService;
            _bookingService = bookingService;
            _cityService = cityService;
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
            roomBooking.Citys = _cityService.GetAllNotDeleted();
            roomBooking.Visitors = _visitorService.GetAllNotDeletedIncluded();
            return View(roomBooking);
        }
        [HttpPost]
        public IActionResult Book(BookRoomDto roomBooking)
        {
            Visitor roomVisitor = new Visitor();
            Booking booking = new Booking();
            if (roomBooking.VisitorId == 0)
            {
                roomVisitor.Person = new Person()
                {
                    FirstName = roomBooking.Visitor.Person.FirstName,
                    LastName =  roomBooking.Visitor.Person.LastName,
                    CityId = roomBooking.Visitor.Person.CityId
                };
                _personService.Create(roomVisitor.Person);    
                _visitorService.Create(roomVisitor);
            }
            
            booking.VisitorId = roomBooking.VisitorId == 0? roomVisitor.Id : roomBooking.VisitorId;
            booking.RoomId = roomBooking.RoomId;
            booking.Date = DateTime.Now.AddDays(1);
            _bookingService.Create(booking);
            var room = _roomService.Get(roomBooking.RoomId);
            return RedirectToAction("Details", "Hotel", new {Id = room.HotelId });
        }
        public IActionResult Checkin (int roomId, int hotelId)
        {
            _roomService.CheckIn(roomId);
            return RedirectToAction("Details", "Hotel", new { Id =  hotelId });
        }
        public IActionResult Checkout(int roomId, int hotelId)
        {
            _roomService.CheckOut(roomId);
            return RedirectToAction("Details", "Hotel", new { Id = hotelId });
        }
    }
}
