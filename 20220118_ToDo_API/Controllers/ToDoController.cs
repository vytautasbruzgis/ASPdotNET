using _20220118_School_API.Data;
using _20220118_School_API.Dtos;
using _20220118_School_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20220118_School_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private DataContext _context;
        private IMapper _mapper;
        public ToDoController(DataContext dataContext, IMapper mapper)
        {
            _context = dataContext;
            _mapper = mapper;
        }
        [HttpGet]
        public List<ToDo> Get()
        {
            return _context.ToDos.ToList();
        }
        [HttpPost]
        public string Create(ToDoDto toDoDto)
        {
            var toDo = _mapper.Map<ToDo>(toDoDto);
            _context.ToDos.Add(toDo);
            _context.SaveChanges();
            return "Created";
        }
    }
}
