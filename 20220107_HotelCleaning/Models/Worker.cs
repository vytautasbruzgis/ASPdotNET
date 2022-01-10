using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models
{
    public class Worker : Entity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string JobTypeId { get; set; }
        public JobType JobType { get; set; }
        public List<HotelTask> Tasks { get; set; }
    }
}
