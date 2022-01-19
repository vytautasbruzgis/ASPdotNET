using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Services
{
    public class JobTypeService
    {
        private JobTypeRepository _jobTypeRepo;

        public JobTypeService(JobTypeRepository jobTypeRepository)
        {
            _jobTypeRepo = jobTypeRepository;
        }

        public void Create(JobType jobType)
        {
            _jobTypeRepo.Add(jobType);
        }
        public List<JobType> GetAllNotDeleted()
        {
            return _jobTypeRepo.GetAllNotDeleted();    
        }
    }
}
