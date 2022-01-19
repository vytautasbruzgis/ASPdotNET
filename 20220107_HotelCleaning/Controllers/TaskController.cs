using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Models.Automapper;
using _20220107_HotelCleaning.Models.Dtos;
using _20220107_HotelCleaning.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _20220107_HotelCleaning.Controllers
{
    public class TaskController : Controller
    {
        private TaskService _taskService;
        private TaskTypeService _taskTypeService;
        private WorkerService _workerService;

        private IMapper _mapper;

        public TaskController(TaskService taskService, TaskTypeService taskTypeService, WorkerService workerService, IMapper mapper)
        {
            _taskService = taskService;
            _taskTypeService = taskTypeService;
            _workerService = workerService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderRoomCleaning(int roomId, int hotelId)
        {
            HotelTaskDto hotelTaskDto = new HotelTaskDto();

            hotelTaskDto.RoomId = roomId;
            hotelTaskDto.HotelId = hotelId;
            hotelTaskDto.TaskTypeId = 1;
            hotelTaskDto.TaskTypes = _taskTypeService.GetAllNotDeleted();
            hotelTaskDto.Workers = _workerService.GetAvailableCleaners();
            hotelTaskDto.CompleteUntil = System.DateTime.Now.AddDays(1);
            
            HotelTask hotelTask = new HotelTask();
            _mapper.Map(hotelTaskDto, hotelTask);
            
            return View(hotelTaskDto);
        }
        [HttpPost]
        public IActionResult OrderRoomCleaning(HotelTaskDto hotelTaskDto)
        {
            if (!ModelState.IsValid)
            {
                hotelTaskDto.TaskTypes = _taskTypeService.GetAllNotDeleted();
                hotelTaskDto.Workers = _workerService.GetAvailableCleaners();
                return View(hotelTaskDto);
            }
            _taskService.Create(new HotelTask()
            {
                TaskTypeId = hotelTaskDto.TaskTypeId,
                RoomId = hotelTaskDto.RoomId,
                CompleteUntil = hotelTaskDto.CompleteUntil,
                WorkerId = hotelTaskDto.WorkerId
            });
            return RedirectToAction("Details", "Hotel", new {Id = hotelTaskDto.HotelId});
        }
        public IActionResult TaskFinished(int roomId, int hotelId)
        {
            _taskService.FinishCleaningTask(roomId);
            return RedirectToAction("Details", "Hotel", new { Id = hotelId });
        }
    }
}
