using _20211230_IgnitisHomeWork_V2.Models;
using _20211230_IgnitisHomeWork_V2.Models.Dtos;
using _20211230_IgnitisHomeWork_V2.Services;
using Microsoft.AspNetCore.Mvc;

namespace _20211230_IgnitisHomeWork_V2.Controllers
{
    public class RegistrationAttributeController : Controller
    {
        private RegistrationAttributesService _regAttrService;
        private ContractorTypeService _contrTypeService;
        private CalculationTypeService _calcTypeService;
        private CustomerImportanceService _custImportanceService;
        public RegistrationAttributeController(RegistrationAttributesService regAttrService, ContractorTypeService contrTypeService,
            CustomerImportanceService custImpService, CalculationTypeService calcTypeService)
        {
            _regAttrService = regAttrService;
            _contrTypeService = contrTypeService;
            _calcTypeService = calcTypeService;
            _custImportanceService = custImpService;
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
                ContractorTypes = _contrTypeService.GetAll(),
                CalculationTypes = _calcTypeService.GetAll(),
                CustomerImportances = _custImportanceService.GetAll()
            };
            return View(regPoz);
        }
    }
}
