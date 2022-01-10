using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Services
{
    public class HotelService
    {
        private RoomService _roomService;
        private HotelRepository _hotelRepo;
        public HotelService(HotelRepository hotelRepository, RoomService roomService)
        {
            _hotelRepo = hotelRepository;
            _roomService = roomService;
        }

        public List<Hotel> GetAllNotDeleted()
        {
            return _hotelRepo.GetAllNotDeletedIncluded();
        }

        public List<Hotel> GetAllNotFilled()
        {
            return GetAllNotDeleted().Where(x => x.Rooms.Count < x.RoomsInHotel).ToList();
        }
        public Hotel Get(int id)
        {
            var hotel = _hotelRepo.GetIncluded(id);
            hotel.Rooms = _roomService.GetRoomsByHotel(id);
            return hotel;
        }
    }
}
