using _20220209_School_API.Dtos;
using _20220209_School_API.Models;
using _20220209_School_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _20220209_School_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<StudentDto> students = await _studentService.GetAllAsync();
                return Ok(students);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _studentService.DeleteAsync(id);
                return NoContent();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateDto studentCreate)
        {
            try
            {
                StudentDto createdStudent = await _studentService.CreateAsync(new StudentDto
                {
                    FirstName = studentCreate.FirstName,
                    LastName = studentCreate.LastName,
                    SchoolId = studentCreate.SchoolId
                });
                return Created("", createdStudent);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
