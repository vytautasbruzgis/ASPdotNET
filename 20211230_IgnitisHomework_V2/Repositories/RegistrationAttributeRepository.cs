using _20211230_IgnitisHomework_V2.Data;
using _20211230_IgnitisHomework_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;

namespace _20211230_IgnitisHomework_V2.Repositories
{
    public class RegistrationAttributeRepository :RepositoryBase<RegistrationAttribute>
    {
        public RegistrationAttributeRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
