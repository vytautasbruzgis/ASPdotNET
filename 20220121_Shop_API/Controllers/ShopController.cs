using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _20220121_Shop_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private ShopService _shopService;

        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ShopDto shopDto = new ShopDto();
            shopDto = _shopService.Get(id);
            return Ok(shopDto);
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ShopDto> shopDtos = new List<ShopDto>();
            shopDtos = _shopService.GetAll();
            return Ok(shopDtos);
        }

        [HttpPost]
        public IActionResult Create(ShopCreateDto shopDto)
        {
            try
            {
                int newItemId = _shopService.Create(shopDto);
                return Created("", newItemId);
            } 
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }
     }
}
