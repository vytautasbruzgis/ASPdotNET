using _20211228_IgnitisHomeWork.Models;
using _20211228_IgnitisHomeWork.Repositories;
using System.Collections.Generic;

namespace _20211228_IgnitisHomeWork.Services
{
    public class CustomerImportanceService
    {
        private CustomerImportanceRepository _custImportanceRepo;
        public CustomerImportanceService(CustomerImportanceRepository customerImportanceRepo)
        {
            _custImportanceRepo = customerImportanceRepo;
        }
        public List<CustomerImportanceModel> GetAll()
        {
            return _custImportanceRepo.GetAll();
        }
    }
}
