using _20211228_IgnitisHomeWork.Data;
using _20211228_IgnitisHomeWork.Models;

namespace _20211228_IgnitisHomeWork.Repositories
{
    public class ContractorTypeRepository : RepositoryBase<ContractorTypeModel>
    {
        public ContractorTypeRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
