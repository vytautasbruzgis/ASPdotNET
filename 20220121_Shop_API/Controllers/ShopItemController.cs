using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using _20220121_Shop_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetById(int id)
        {   
            try
            {
                ShopItemDto shopItem = await _shopItemService.GetAsync(id);
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
        public async Task<IActionResult> Create(ShopItemDto dto)
        {
            try
            {
                int newItemId = await _shopItemService.CreateAsync(dto);
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
