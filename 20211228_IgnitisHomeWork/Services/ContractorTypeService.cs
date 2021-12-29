using _20211228_IgnitisHomeWork.Models;
using _20211228_IgnitisHomeWork.Repositories;
using System.Collections.Generic;

namespace _20211228_IgnitisHomeWork.Services
{
    public class ContractorTypeService
    {
        private ContractorTypeRepository _contrTypeRepo;
        public ContractorTypeService(ContractorTypeRepository contractorTypeRepository)
        {
            _contrTypeRepo = contractorTypeRepository;
        }

        public List<ContractorTypeModel> GetAll()
        {
            return _contrTypeRepo.GetAll();
        }
    }
}
