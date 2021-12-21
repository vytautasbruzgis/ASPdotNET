using _20211215_EF_ShopApp.Models;
using _20211215_EF_ShopApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211215_EF_ShopApp.Controllers
{
    public class ShopItemController : Controller
    {
        private ShopService _shopService;
        private ShopItemService _shopItemService;
        public ShopItemController(ShopService shopService, ShopItemService shopItemService)
        {
            _shopService = shopService;
            _shopItemService = shopItemService;
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
            ShopItemWithShopListModel viewData = new ShopItemWithShopListModel();
            viewData.ShopList = _shopService.GetAllNotDeleted();
            if(shopId != null)
            {
                viewData.ShopId = (int)shopId;
            }
            return View(viewData);
        }
        [HttpPost]
        public IActionResult Create(ShopItemWithShopListModel model)
        {
            _shopItemService.Create(model);
            return RedirectToAction("ItemList");
        }
        public IActionResult Update(int id)
        {
            var shopItem = _shopItemService.GetById(id);
            if (shopItem != null)
            {
                ShopItemWithShopListModel model = new ShopItemWithShopListModel()
                {
                    Id = shopItem.Id,
                    Name = shopItem.Name,
                    ExpiryDate = shopItem.ExpiryDate,
                    ShopId = shopItem.ShopId,
                    ShopList = _shopService.GetSelectedAndAllNotDeleted(shopItem.ShopId)
                };
                return View(model);
            } 
            return RedirectToAction("ItemList");
        }
        [HttpPost]
        public IActionResult Update(ShopItemWithShopListModel model)
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
