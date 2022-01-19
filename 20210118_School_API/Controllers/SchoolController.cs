using _20210118_School_API.Dtos;
using _20210118_School_API.Models;
using _20210118_School_API.Services;
using AutoMapper;
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
    public class SchoolController : ControllerBase
    {
        private readonly ILogger<SchoolController> _logger;
        private readonly IMapper _mapper;
        private readonly SchoolService _schoolService;

        public SchoolController(ILogger<SchoolController> logger, IMapper mapper, SchoolService schoolService)
        {
            _logger = logger;
            _mapper = mapper;
            _schoolService = schoolService;
        }

        [HttpGet]
        public List<SchoolDto> GetAll()
        {
            List<SchoolDto> schools = _mapper.Map<List<SchoolDto>>(_schoolService.GetAll());
            return schools;
        }
        [HttpGet("{id}")]
        public SchoolDto Get(int id)
        {
            var school = _mapper.Map<SchoolDto>(_schoolService.Get(id));
            return school;
        }
        [HttpPost]
        public SchoolRequestResponse Create(SchoolDto schoolDto)
        {
            SchoolRequestResponse  response = new SchoolRequestResponse();
            var school = _mapper.Map<School>(schoolDto);
            _schoolService.Create(school);
            return response;
        }
        [HttpDelete("{id}")]
        public SchoolRequestResponse Delete(int id)
        {
            SchoolRequestResponse response = new SchoolRequestResponse();
            try
            {
                _schoolService.Delete(id);
                response.Status = "OK";
                response.ErrorCode = "0";
                response.ErrorMessage = response.GetErrorText(response.ErrorCode);
            }
            catch (ArgumentException e) {
                response.Status = "Error";
                response.ErrorCode = e.Message;
                response.ErrorMessage = response.GetErrorText(response.ErrorCode);
            }
            return response;
        }
        [HttpPut("{id}")]
        public SchoolRequestResponse Update(int id, SchoolDto schoolDto)
        {
            SchoolRequestResponse response = new SchoolRequestResponse();
            var school = _schoolService.Get(id);
            if (school != null)
            {
                school = _mapper.Map(schoolDto, school);
                _schoolService.Update(school);
            }
            return response;
        }

    }
}
