using _20211228_IgnitisHomeWork.Data;
using _20211228_IgnitisHomeWork.Models;

namespace _20211228_IgnitisHomeWork.Repositories
{
    public class RegistrationAttributesRepository : RepositoryBase<RegistrationattributesModel>
    {
        public RegistrationAttributesRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
