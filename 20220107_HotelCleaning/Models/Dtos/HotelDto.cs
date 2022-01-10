using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models.Dtos
{
    public class HotelDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int HotelId { get; set; }
    }

    public class HotelDetailsDto{
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool CanCreateRooms { get; set; }
        public List<Room> Rooms { get; set; }
    }
    public class HotelDtoMapper
    {
        public static HotelDto MapToListDto (Hotel hotel)
        {
            return new HotelDto()
            {
                Name = hotel.Name,
                Address = hotel.Address,
                City = hotel.City.Name,
                HotelId = hotel.Id
            };
        }
        public static HotelDetailsDto MapToDetailsDto(Hotel hotel)
        {
            return new HotelDetailsDto()
            {
                HotelId = hotel.Id,
                Name = hotel.Name,
                City = hotel.City.Name,
                Rooms = hotel.Rooms,
                CanCreateRooms = hotel.RoomsInHotel > hotel.Rooms.Count ? true : false 

            };
        }
        
    }
}
