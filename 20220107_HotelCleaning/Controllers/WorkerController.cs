using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Models.Dtos;
using _20220107_HotelCleaning.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Controllers
{
    public class WorkerController: Controller
    {
        private WorkerService _workerService;
        private CityService _cityService;
        private PersonService _personService;
        private JobTypeService _jobTypeService;

        public WorkerController(WorkerService workerService, CityService cityService, PersonService personService, JobTypeService jobTypeService)
        {
            _workerService = workerService;
            _cityService = cityService;
            _personService = personService;
            _jobTypeService = jobTypeService;
        }
        public IActionResult List()
        {
            List<WorkerDto> workerListDto = new List<WorkerDto>();

            var workers = _workerService.GetAllNotDeletedIncluded();
            foreach (var worker in workers)
            {
                workerListDto.Add(
                    new WorkerDto()
                    {
                        FirstName = worker.Person.FirstName,
                        LastName = worker.Person.LastName,
                        FullName = worker.Person.FullName,
                        JobTypeName = worker.JobType.Name,
                        UncompletedTasks = worker.Tasks.Count(x => x.IsCompleted == false && x.IsDeleted == false)
                    }
                );
            }
            return View(workerListDto);
        }
        public IActionResult Create()
        {
            WorkerDto workerDto = new WorkerDto();
            workerDto.Cities = _cityService.GetAllNotDeleted();
            workerDto.JobTypes = _jobTypeService.GetAllNotDeleted();
            return View(workerDto);
        }
        [HttpPost]
        public IActionResult Create(WorkerDto workerDto)
        {
            if (!ModelState.IsValid)
            {
                workerDto.Cities = _cityService.GetAllNotDeleted();
                workerDto.JobTypes = _jobTypeService.GetAllNotDeleted();
                return View(workerDto);
            }
            Person person = new Person()
            {
                FirstName = workerDto.FirstName,
                LastName = workerDto.LastName,
                CityId = workerDto.CityId
            };
            _personService.Create(person);
            Worker worker = new Worker()
            {
                PersonId = person.Id,
                JobTypeId = workerDto.JobTypeId
            };
            _workerService.Create(worker);
            return RedirectToAction("List");
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
