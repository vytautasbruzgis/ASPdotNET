using _20220209_School_API.Repositories;
using _20220209_School_API.Data;
using _20220209_School_API.Models;

namespace _20220209_School_API.Repositories
{
    public class SchoolRepository : NamedRepositoryBase<School>
    {
        public SchoolRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
