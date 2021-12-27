using _20211215_EF_ShopApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211215_EF_ShopApp.Controllers
{
    public class TagController : Controller
    {
        private TagService _tagService;
        public TagController(TagService tagService)
        {
            _tagService = tagService;
        }

        public IActionResult TagList()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
