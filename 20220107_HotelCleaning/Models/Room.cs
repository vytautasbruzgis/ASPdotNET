using System;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models
{
    public class Room : NamedEntity
    {
        public int RoomNumber { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int FloorNumber { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsCleaned { get; set; } = true;
        public List<HotelTask> Tasks { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
