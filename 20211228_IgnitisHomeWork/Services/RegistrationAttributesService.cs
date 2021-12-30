using _20211230_IgnitisHomeWork_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;

namespace _20211230_IgnitisHomeWork_V2.Services
{
    public class RegistrationAttributesService
    {
        private RegistrationAttributesRepository _regAttRepo;
        public RegistrationAttributesService(RegistrationAttributesRepository regAttRepo)
        {
            _regAttRepo = regAttRepo;
        }
        public RegistrationattributesModel Get(int id)
        {
            return _regAttRepo.Get(id);
        }
    }
}
