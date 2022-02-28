using _20220216_DevBridge_Points_API.Dtos;
using _20220216_DevBridge_Points_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PointListController : ControllerBase
    {
        private readonly PointListService _pointListService;
        public PointListController(PointListService pointListService)
        {
            _pointListService = pointListService;
        }

       [HttpPost]
       public async Task<IActionResult> Create(PointListCreateDto pointListCreate)
        {
            try
            {
                var createdPointList = await _pointListService.CreateAsync(pointListCreate);
                return Created("", createdPointList);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var pointLists = await _pointListService.GetAllAsync();
                return Ok(pointLists);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet ("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                PointListDto pointListDto = await _pointListService.GetAsync(id);
                return Ok(pointListDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _pointListService.DeleteAsync(id);
                return NoContent();
            } catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}
