using System;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models.Dtos
{
    public class HotelTaskDto
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public int WorkerId
        {
            get; set; 
        }
        public List<Worker> Workers { get; set; }
        public int TaskTypeId { get; set; }
        public List<TaskType> TaskTypes { get; set; }
        public DateTime CompleteUntil { get; set; }
    }
}
