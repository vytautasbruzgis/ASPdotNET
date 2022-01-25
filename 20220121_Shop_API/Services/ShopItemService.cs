using _20210118_School_API.Services;
using _20220121_Shop_API.CustomExceptions;
using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using _20220121_Shop_API.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20220121_Shop_API.Services
{
    public class ShopItemService : ServiceBase<ShopItem, ShopItemRepository, ShopItemDto>
    {
        private ItemService _itemService;
        private ShopService _shopService;
        public ShopItemService(ShopItemRepository repository, IMapper mapper, ItemService itemService, ShopService shopService) : base(repository, mapper)
        {
            _itemService = itemService;
            _shopService = shopService;
        }
        new public int Create(ShopItemDto dto)
        {
            try
            {
                ItemDto item = _itemService.Get(dto.ItemId);
                ShopDto shop = _shopService.Get(dto.ShopId);
                if (dto.Price == 0)
                {
                    throw new ZeroPriceException("Price must not be zero");
                }
                return base.Create(dto);
            } catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public List<ShopItemDto> GetByShopId(int shopId)
        {
            List<ShopItemDto> shopItemDtos = new List<ShopItemDto>();
            List<ShopItem> shopItems = new List<ShopItem>();
            shopItems = _repo.GetAllNotDeleted().Where(x => x.ShopId == shopId).ToList();

            return _mapper.Map<List<ShopItemDto>>(shopItems);
        }
    }
}
