using _20211228_IgnitisHomeWork.Data;
using _20211228_IgnitisHomeWork.Models;

namespace _20211228_IgnitisHomeWork.Repositories
{
    public class CustomerImportanceRepository : RepositoryBase<CustomerImportanceModel>
    {
        public CustomerImportanceRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
