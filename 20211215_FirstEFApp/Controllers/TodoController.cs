using _20211215_FirstEFApp.Data;
using _20211215_FirstEFApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20211215_FirstEFApp.Controllers
{
    public class ToDoController : Controller

    {
        private readonly DataContext _dbContext;
        public ToDoController  (DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            _dbContext.categories.Include(c=>c.ToDos)
                .Where(c=>c.Name == "Category1")
                .SelectMany(c =>c.ToDos)
                .ToList();

            var toDos = _dbContext.toDos.ToList();
            return View(toDos);
        }
    }
}
