using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Services
{
    public class RoomService
    {
        private RoomRepository _roomRepo;
        private BookingService _bookingService;
        public RoomService(RoomRepository roomRepository, BookingService bookingService)
        {
            _roomRepo = roomRepository;
            _bookingService = bookingService;
        }

        public List<Room> GetRoomsByHotel(int hotelId)
        {
            var rooms = _roomRepo.GetRoomsByHotel(hotelId).ToList();
            foreach (Room room in rooms)
            {
                /* čia reikėtų dar ir datą prafiltruoti */
                room.CanBeBooked = room.Bookings.Where(x => x.RoomId == room.Id && (x.IsCheckedIn == false || x.IsCheckedOut == false)).Any() == false && room.IsCleaned && room.IsCheckedIn == false ? true : false ;
                room.IsCleaningOrdered = room.Tasks.Where(x => x.IsCompleted == false && x.TaskTypeId == 1).Any();

            }
            return rooms;
        }
        public void Create(Room room)
        {
            _roomRepo.Add(room);
        }
        public Room Get(int id)
        {
           return _roomRepo.Get(id);
        }
        public void Update(Room room)
        {
            _roomRepo.Update(room);
        }
        public void CheckIn(int id)
        {
            var room = Get(id);
            room.Bookings = _bookingService.GetByRoom(room.Id);
            /* reikėtų susitvarkius, kad gauna tik tą vieną palitki tik vieną */
            foreach (var booking in room.Bookings)
            {
                booking.IsCheckedIn = true;
                _bookingService.Update(booking);
            }
            room.IsCheckedIn = true;
            _roomRepo.Update(room);
        }
        public void CheckOut(int id)
        {
            var room = Get(id);
            room.Bookings = _bookingService.GetByRoom(room.Id);
            foreach (var booking in room.Bookings)
            {
                booking.IsCheckedOut = true;
                booking.CheckedOut = System.DateTime.Now;
                _bookingService.Update(booking);
            }
            room.IsCheckedIn = false;
            room.IsCleaned = false;
            _roomRepo.Update(room);
        }
    }
}
