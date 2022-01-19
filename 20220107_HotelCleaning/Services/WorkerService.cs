using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Services
{
    public class WorkerService
    {
        private WorkerRepository _workerRepo;

        public WorkerService(WorkerRepository workerRepository)
        {
            _workerRepo = workerRepository;
        }

        public void Create(Worker worker)
        {
            _workerRepo.Add(worker);
        }
        public List<Worker> GetAllNotDeletedIncluded()
        {
            return _workerRepo.GetAllNotDeletedIncluded();
        }
        public List<Worker> GetAllNotDeleted()
        {
            return _workerRepo.GetAllNotDeleted();
        }
        public List<Worker> GetAvailableCleaners()
        {
            List<Worker> result = new List<Worker>();
            var workers = GetAllNotDeletedIncluded();
            foreach (var worker in workers)
            {
                if (worker.Tasks.Count(x => x.TaskTypeId == 1) < 5)
                {
                    result.Add(worker);
                }
            }
            return result;
        }
    }
}
