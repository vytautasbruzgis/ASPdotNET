using _20220216_DevBridge_Points_API.Dtos;
using _20220216_DevBridge_Points_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private readonly PointService _pointService;
        public PointController(PointService pointService)
        {
            _pointService = pointService;
        }

        [HttpPost]
        public async Task<IActionResult> Create (PointCreateDto createDto)
        {
            //try
            //{
                createDto.PointListId = createDto.PointListId == 0 ? null : createDto.PointListId;
                var createdObject = await _pointService.CreateAsync(createDto);
                return Created("", createdObject);
            //} catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }
    }
}
