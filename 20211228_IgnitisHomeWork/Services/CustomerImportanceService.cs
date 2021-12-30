using _20211230_IgnitisHomeWork_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;
using System.Collections.Generic;

namespace _20211230_IgnitisHomeWork_V2.Services
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
