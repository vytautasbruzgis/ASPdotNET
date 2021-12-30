using _20211230_IgnitisHomeWork_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;
using System.Collections.Generic;

namespace _20211230_IgnitisHomeWork_V2.Services
{
    public class CalculationTypeService
    {
        private CalculationTypeRepository _calcTypeRepo;
        public CalculationTypeService(CalculationTypeRepository calcTypeRepo)
        {
            _calcTypeRepo = calcTypeRepo;
        }
        public List<CalculationTypeModel> GetAll()
        {
            return _calcTypeRepo.GetAll();
        }
    }
}
