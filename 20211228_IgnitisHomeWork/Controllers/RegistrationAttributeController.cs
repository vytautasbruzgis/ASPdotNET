using _20211228_IgnitisHomeWork.Models;
using _20211228_IgnitisHomeWork.Models.Dtos;
using _20211228_IgnitisHomeWork.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211228_IgnitisHomeWork.Controllers
{
    public class RegistrationAttributeController : Controller
    {
        private RegistrationAttributesService _regAttrService;
        private ContractorTypeService _contrTypeService;
        public RegistrationAttributeController(RegistrationAttributesService regAttrService, ContractorTypeService contrTypeService)
        {
            _regAttrService = regAttrService;
            _contrTypeService = contrTypeService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("RegPoz", new { id = 1});
        }
        public IActionResult RegPoz(int id)
        {
            RegPozDto regPoz = new RegPozDto()
            {
                Registrationattributes = _regAttrService.Get(id),
                ContractorTypes = _contrTypeService.GetAll()
            };
            return View(regPoz);
        }
    }
}
