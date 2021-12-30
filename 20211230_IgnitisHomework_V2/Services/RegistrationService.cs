using _20211230_IgnitisHomework_V2.Repositories;

namespace _20211230_IgnitisHomework_V2.Services
{
    public class RegistrationService
    {
        private RegistrationRepository _regRepo;
        public RegistrationService(RegistrationRepository registrationRepository)
        {
            _regRepo = registrationRepository;
        }
    }
}
