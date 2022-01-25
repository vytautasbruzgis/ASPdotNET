using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using _20220121_Shop_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _20220121_Shop_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private ShopItemService _shopItemService;

        public ShopItemController(ShopItemService shopItemService)
        {
            _shopItemService = shopItemService;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {   
            try
            {
                ShopItemDto shopItem = _shopItemService.Get(id);
                return Ok(shopItem);
            } catch (ArgumentException e)
            {
                return NotFound(e.Message);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                List<ShopItemDto> shopItems = _shopItemService.GetAll();
                return Ok(shopItems);
            } catch (ArgumentException e)
            {
                return NotFound(e.Message);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Create(ShopItemDto dto)
        {
            try
            {
                int newItemId = _shopItemService.Create(dto);
                return Created("", newItemId);
            } catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
