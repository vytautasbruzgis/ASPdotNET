using _20211207_ToDoList.Models;
using _20211207_ToDoList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _20211207_ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ToDoListService _todolistService;

        public HomeController(ILogger<HomeController> logger, ToDoListService todolistService)
        {
            _todolistService = todolistService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ToDoList()
        {
            List<ToDo> todoList = _todolistService.GetAll();
            return View(todoList);
        }
        public IActionResult AddNewForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewForm(ToDo model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            } else
            {
                ToDo toDo = new ToDo() { Name = model.Name, Description = model.Description, Id = ++ToDo.IdCounter };
                _todolistService.Add(toDo);
                return RedirectToAction("ToDoList");
            }
            
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) { return RedirectToAction("HttpNotFound"); }
            _todolistService.Remove((int)id);
            return RedirectToAction("ToDoList");
        }

        public ActionResult HttpNotFound()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
