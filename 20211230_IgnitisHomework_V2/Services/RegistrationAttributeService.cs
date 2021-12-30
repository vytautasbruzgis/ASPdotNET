using _20211230_IgnitisHomework_V2.Repositories;

namespace _20211230_IgnitisHomework_V2.Services
{
    public class RegistrationAttributeService
    {
        private RegistrationAttributeRepository _regAttributeRepo;
        public RegistrationAttributeService(RegistrationAttributeRepository regAttributeRepo)
        {
            _regAttributeRepo = regAttributeRepo;
        }
    }
}
