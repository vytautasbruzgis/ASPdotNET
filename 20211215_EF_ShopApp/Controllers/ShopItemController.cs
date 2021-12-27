using _20211215_EF_ShopApp.Models;
using _20211215_EF_ShopApp.Models.Dtos;
using _20211215_EF_ShopApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _20211215_EF_ShopApp.Controllers
{
    public class ShopItemController : Controller
    {
        private ShopService _shopService;
        private ShopItemService _shopItemService;
        private TagService _tagService;
        private ItemTagService _itemTagService;

        public ShopItemController(ShopService shopService, ShopItemService shopItemService, TagService tagService, ItemTagService itemTagService)
        {
            _shopService = shopService;
            _shopItemService = shopItemService;
            _tagService = tagService;
            _itemTagService = itemTagService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ItemList()
        {
            var shopItems = _shopItemService.GetAllNotDeleted();
            return View(shopItems);
        }

        public IActionResult Delete(int id)
        {
            _shopItemService.Delete(id);
            return RedirectToAction("ItemList");
        }

        public IActionResult Create(int? shopId)
        {
            ShopItemDto viewData = new ShopItemDto();
            viewData.ShopList = _shopService.GetAllNotDeleted();
            viewData.TagList = _tagService.GetAllNotDeleted();
            if (shopId != null)
            {
                viewData.ShopId = (int)shopId;
            }
            return View(viewData);
        }
        [HttpPost]
        public IActionResult Create(ShopItemDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ShopItemModel shopItem = new ShopItemModel()
            {
                Name = model.Name,
                ExpiryDate = model.ExpiryDate,
                ShopId = model.ShopId
            };
            _shopItemService.Create(shopItem);

            foreach (int tagId in model.SelectedTagIds)
            {
                _itemTagService.Create(new ItemTagModel()
                {
                    TagId = tagId,
                    ShopItemId = shopItem.Id
                });
            }

            return RedirectToAction("ItemList");
        }
        public IActionResult Update(int id)
        {
            var shopItem = _shopItemService.GetById(id);
            if (shopItem != null)
            {
                List<int> selectedIds = _itemTagService.GetTagsByItemId(shopItem.Id);
                ShopItemDto model = new ShopItemDto()
                {
                    Id = shopItem.Id,
                    Name = shopItem.Name,
                    ExpiryDate = shopItem.ExpiryDate,
                    ShopId = shopItem.ShopId,
                    ShopList = _shopService.GetSelectedAndAllNotDeleted(shopItem.ShopId),
                    SelectedTagIds = selectedIds,
                    TagList = _tagService.GetAllNotDeletedUnionSelected(selectedIds)
                };
                return View(model);
            } 
            return RedirectToAction("ItemList");
        }
        [HttpPost]
        public IActionResult Update(ShopItemDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _shopItemService.Update(model);
            return RedirectToAction("ItemList");
        }
    }
}
