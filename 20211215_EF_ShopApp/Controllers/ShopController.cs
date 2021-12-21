using _20211215_EF_ShopApp.Models;
using _20211215_EF_ShopApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211215_EF_ShopApp.Controllers
{
    public class ShopController : Controller
    {
        private ShopService _shopService;
        private ShopItemService _shopItemService;
        public ShopController(ShopService shopService, ShopItemService shopItemService)
        {
            _shopService = shopService;
            _shopItemService = shopItemService; 
        }
        public IActionResult Index()
        {
            return RedirectToAction("ItemList", "ShopItem");
        }
        public IActionResult ShopList()
        {
            return View(_shopService.GetAllNotDeleted());
        }
        public IActionResult Details(int id)
        {
            var shop = _shopService.GetById(id);
            shop.ShopItems = _shopItemService.GetShopItems(shop.Id);
            return View(shop);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ShopModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            } else
            {
                _shopService.Add(model);
                return RedirectToAction("ShopList");
            }
        }
        public IActionResult Delete(int id)
        {
            _shopService.Delete(id);
            return RedirectToAction("ShopList");
        }

        public IActionResult Update(int id)
        {
            ShopModel shop = _shopService.GetById(id);
            return View(shop);
        }
        [HttpPost]
        public IActionResult Update(ShopModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _shopService.Update(model);
            return RedirectToAction("ShopList");
        }
    }
}
