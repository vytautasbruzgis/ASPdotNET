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
    public class SchoolController : ControllerBase
    {
        private SchoolService _schoolService;
        public SchoolController(SchoolService schoolService)
        {
            _schoolService = schoolService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<SchoolDto> schoolDtos;
                schoolDtos = await _schoolService.GetAllAsync();
                return Ok(schoolDtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public async Task<IActionResult> Create(SchoolCreateDto schoolCreateDto)
        {
            try
            {
                SchoolDto createdSchool = await _schoolService.CreateAsync(new SchoolCreateDto
                {
                    Name = schoolCreateDto.Name
                });
                return Created("", createdSchool);
            } catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
