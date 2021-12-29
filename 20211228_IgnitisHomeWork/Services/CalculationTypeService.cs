using _20211228_IgnitisHomeWork.Models;
using _20211228_IgnitisHomeWork.Repositories;
using System.Collections.Generic;

namespace _20211228_IgnitisHomeWork.Services
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
