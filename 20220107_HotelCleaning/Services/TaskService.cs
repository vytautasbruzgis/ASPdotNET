using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _20220107_HotelCleaning.Services
{
    public class TaskService
    {
        private TaskRepository _taskRepo;
        private RoomService _roomService;

        public TaskService(TaskRepository taskRepository, RoomService roomService)
        {
            _taskRepo = taskRepository;
            _roomService = roomService;
        }

        public void Create(HotelTask task)
        {
            _taskRepo.Add(task);
        }
        public void FinishCleaningTask(int roomId)
        {
            Room room = _roomService.Get(roomId);
            room.IsCleaned = true;
            _roomService.Update(room);

            HotelTask task = _taskRepo.GetCleaningTaskForRoom(roomId);
            task.IsCompleted = true;
            _taskRepo.Update(task);
        }
    }
}
