using _20211228_IgnitisHomeWork.Models;
using _20211228_IgnitisHomeWork.Repositories;

namespace _20211228_IgnitisHomeWork.Services
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
