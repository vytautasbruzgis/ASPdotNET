using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models
{
    public class Hotel : NamedEntity
    {
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int FloorsCount { get; set; }
        public int RoomsInHotel { get; set; } = 0;
        public List<Room> Rooms { get; set;}
    }
}
