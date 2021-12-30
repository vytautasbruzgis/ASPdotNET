using _20211230_IgnitisHomeWork_V2.Data;
using _20211230_IgnitisHomeWork_V2.Models;

namespace _20211230_IgnitisHomeWork_V2.Repositories
{
    public class CustomerImportanceRepository : RepositoryBase<CustomerImportanceModel>
    {
        public CustomerImportanceRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
