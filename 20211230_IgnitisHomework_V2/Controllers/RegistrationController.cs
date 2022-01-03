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
            _regAttributeService = registrationAttributeService;
        }
        public IActionResult Index()
        {
            RegistrationViewDto model = new RegistrationViewDto();
            model.Registration = _regService.Get(1);
            return View(model);
        }

        public IActionResult Update(RegistrationViewDto model)
        {
            foreach (var attribute in model.Registration.Attributes)
            {
                var tmpAttribute = _regAttributeService.Get(attribute.Id);
                tmpAttribute.SelectedOptionId = attribute.SelectedOptionId;
                _regAttributeService.Update(tmpAttribute);
            }
            return RedirectToAction("Index");
        }
    }
}
