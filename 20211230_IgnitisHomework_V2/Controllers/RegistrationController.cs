using _20211230_IgnitisHomework_V2.Models.Dtos;
using _20211230_IgnitisHomework_V2.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211230_IgnitisHomework_V2.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistrationService _regService;
        private RegistrationAttributeService _regAttributeService;
        public RegistrationController(RegistrationService regService, RegistrationAttributeService registrationAttributeService)
        {
            _regService = regService;
            _regAttributeService
        }
        public IActionResult Index()
        {
            RegistrationViewDto model = new RegistrationViewDto();
            return View();
        }
    }
}
