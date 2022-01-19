using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models.Dtos
{
    public class WorkerDto
    {
        public int WorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int JobTypeId { get; set; }
        public string JobTypeName { get; set; }
        public List<JobType> JobTypes { get; set; }

        public List<HotelTask> Tasks { get; set; }
        public int UncompletedTasks { get; set; }
        public int CityId { get; set; }
        public List<City> Cities { get; set; }

    }
}
