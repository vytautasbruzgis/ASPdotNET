using System;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models.Dtos
{
    public class BookRoomDto
    {
        public int RoomId { get; set; }
        public Room room { get; set; }
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
        public List<Visitor> Visitors { get; set; }
        public DateTime Date { get; set; }
        public List<City> Citys { get; set; }

    }
}
