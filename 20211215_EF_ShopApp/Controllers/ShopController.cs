using _20211215_EF_ShopApp.Models;
using _20211215_EF_ShopApp.Services;
using _20211215_FirstEFApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
            //var shopItems = _dataContext.ShopItems.Include(c => c.Shop).Where(c => c.ShopId == 1).ToList();
            var shopItems = _shopItemService.GetAllNotDeleted();
            return View(shopItems);
        }

        public IActionResult ShopList()
        {
            return View(_shopService.GetAllNotDeleted());
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShopModel m)
        {
            if (!ModelState.IsValid)
            {
                return View(m);
            } else
            {
                _shopService.Add(m);
                return RedirectToAction("ShopList");
            }
        }
    }
}
