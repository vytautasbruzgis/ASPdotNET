using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Services
{
    public class RoomService
    {
        private RoomRepository _roomRepo;
        public RoomService(RoomRepository roomRepository)
        {
            _roomRepo = roomRepository;
        }

        public List<Room>? GetRoomsByHotel(int hotelId)
        {
            var rooms = _roomRepo.GetRoomsByHotel(hotelId).ToList();

            return rooms;
        }
    }
}
