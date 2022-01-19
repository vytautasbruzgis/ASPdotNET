using _20210118_School_API.Dtos;
using _20210118_School_API.Models;
using _20210118_School_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20210118_School_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IMapper _mapper;
        private readonly StudentService _studentService;
        private readonly SchoolService _schoolService;

        public StudentController(ILogger<StudentController> logger, IMapper mapper, StudentService studentService, SchoolService schoolService)
        {
            _logger = logger;
            _mapper = mapper;
            _studentService = studentService;
            _schoolService = schoolService;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            Student student = _studentService.Get(id);
            if(student == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<StudentDto>(student));
        }
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(StudentDto studentDto)
        {
            Student student = _mapper.Map<Student>(studentDto);
            School school = _schoolService.Get(student.SchoolId);
            if (school == null)
            {
                return BadRequest();
            } 
            _studentService.Create(student);
            return Ok();
        }
    }
}
