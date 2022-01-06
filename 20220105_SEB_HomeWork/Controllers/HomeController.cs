using _20220105_SEB_HomeWork.Models;
using _20220105_SEB_HomeWork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _20220105_SEB_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CurrencyService _currrencyService;

        public HomeController(ILogger<HomeController> logger, CurrencyService currService)
        {
            _logger = logger;
            _currrencyService = currService;
        }

        public IActionResult Index(DateTime? date)
        {
            if (date == null)
            {
                date = new DateTime(2014, 5, 5);
            }
            var currencies = _currrencyService.GetDataByDate((DateTime)date);
            return View(currencies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
