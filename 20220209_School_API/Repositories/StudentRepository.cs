using _20220209_School_API.Repositories;
using _20220209_School_API.Data;
using _20220209_School_API.Models;

namespace _20220209_School_API.Repositories
{
    public class StudentRepository : RepositoryBase<Student>
    {
        public StudentRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
