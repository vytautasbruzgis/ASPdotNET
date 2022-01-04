using _20211230_IgnitisHomework_V2.Models;
using _20211230_IgnitisHomework_V2.Models.Dtos;
using _20211230_IgnitisHomework_V2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _20211230_IgnitisHomework_V2.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistrationService _regService;
        private RegistrationAttributeService _regAttributeService;
        public RegistrationController(RegistrationService regService, RegistrationAttributeService registrationAttributeService)
        {
            _regService = regService;
            _regAttributeService = registrationAttributeService;
        }
        public IActionResult Index()
        {
            return RedirectToAction ("List");
        }

        public IActionResult Details(int id)
        {
            RegistrationViewDto model = new RegistrationViewDto();
            model.Registration = _regService.Get(id);
            return View(model);
        }
        public IActionResult List()
        {
            List<Registration> registrations = _regService.GetAll();
            return View(registrations);
        }

        public IActionResult Update(RegistrationViewDto model, int id)
        {
            foreach (var attribute in model.Registration.Attributes)
            {
                var tmpAttribute = _regAttributeService.Get(attribute.Id);
                tmpAttribute.SelectedOptionId = attribute.SelectedOptionId;
                _regAttributeService.Update(tmpAttribute);
            }
            return RedirectToAction("Details", new { Id = id });
        }
    }
}
