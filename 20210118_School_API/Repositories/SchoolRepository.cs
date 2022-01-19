using _20210118_School_API.Models;
using _20220118_School_API.Data;

namespace _20210118_School_API.Repositories
{
    public class SchoolRepository : RepositoryBase<School>
    {
        public SchoolRepository(DataContext dataContext) : base(dataContext){
        }

    }
}
