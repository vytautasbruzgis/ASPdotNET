using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models.Dtos
{
    public class RoomCreateDto
    {
        public int? HotelId { get; set; }
        public List<Hotel> Hotels{ get; set;}
        public int RoomNumber { get; set; }
        public int FloorNumber { get; set; }
    }
}
