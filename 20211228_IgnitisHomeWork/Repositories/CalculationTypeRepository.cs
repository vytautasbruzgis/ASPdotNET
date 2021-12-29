using _20211228_IgnitisHomeWork.Data;
using _20211228_IgnitisHomeWork.Models;

namespace _20211228_IgnitisHomeWork.Repositories
{
    public class CalculationTypeRepository : RepositoryBase<CalculationTypeModel>
    {
        public CalculationTypeRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
