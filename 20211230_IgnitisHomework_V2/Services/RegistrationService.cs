using _20211230_IgnitisHomework_V2.Models;
using _20211230_IgnitisHomework_V2.Repositories;
using System.Collections.Generic;

namespace _20211230_IgnitisHomework_V2.Services
{
    public class RegistrationService
    {
        private RegistrationRepository _regRepo;
        private RegistrationAttributeService _regAttributeService;
        public RegistrationService(RegistrationRepository registrationRepository, RegistrationAttributeService regAttributeService)
        {
            _regRepo = registrationRepository;
            _regAttributeService = regAttributeService;
        }

        public Registration Get(int id)
        {
            Registration reg = _regRepo.Get(id);
            reg.Attributes = _regAttributeService.GetByRegistration(id);

            return reg;
        }
        public List<Registration> GetAll()
        {
            return _regRepo.GetAll();
        }
    }
}
