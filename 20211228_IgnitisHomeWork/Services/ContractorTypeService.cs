using _20211230_IgnitisHomeWork_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;
using System.Collections.Generic;

namespace _20211230_IgnitisHomeWork_V2.Services
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
