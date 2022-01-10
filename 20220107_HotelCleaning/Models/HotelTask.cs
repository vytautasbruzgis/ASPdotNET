using System;

namespace _20220107_HotelCleaning.Models
{
    public class HotelTask: Entity
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public DateTime CompleteUntil { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }
    }
}
