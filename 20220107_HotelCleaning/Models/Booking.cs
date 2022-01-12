using System;

namespace _20220107_HotelCleaning.Models
{
    public class Booking: Entity
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
        public DateTime Date { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime? CheckedOut { get; set; }
    }
}
