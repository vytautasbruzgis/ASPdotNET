using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Services
{
    public class TaskTypeService
    {
        private TaskTypeRepository _taskTypeRepo;

        public TaskTypeService(TaskTypeRepository taskTypeRepository)
        {
            _taskTypeRepo = taskTypeRepository;
        }

        public void Create(TaskType taskType)
        {
            _taskTypeRepo.Add(taskType);
        }
        public List<TaskType> GetAllNotDeleted()
        {
            return _taskTypeRepo.GetAllNotDeleted();    
        }
    }
}
