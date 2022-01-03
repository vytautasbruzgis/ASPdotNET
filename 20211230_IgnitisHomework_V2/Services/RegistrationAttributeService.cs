using _20211230_IgnitisHomework_V2.Models;
using _20211230_IgnitisHomework_V2.Repositories;
using System.Collections.Generic;

namespace _20211230_IgnitisHomework_V2.Services
{
    public class RegistrationAttributeService
    {
        private RegistrationAttributeRepository _regAttributeRepo;
        public RegistrationAttributeService(RegistrationAttributeRepository regAttributeRepo)
        {
            _regAttributeRepo = regAttributeRepo;
        }
        public List<RegistrationAttribute> GetByRegistration(int id)
        {
            return _regAttributeRepo.GetByRegistrationId(id);
        }
        public void Update(RegistrationAttribute attribute)
        {
            _regAttributeRepo.Update(attribute);
        }
        public RegistrationAttribute Get(int id)
        {
            return _regAttributeRepo.Get(id);
        }
    }
}
