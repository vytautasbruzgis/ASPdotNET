using _20220118_School_API.Data;

namespace _20210118_School_API.Services
{
    public class StudentService
    {
        private DataContext _context;
        public StudentService(DataContext dataContext)
        {
            _context = dataContext;
        }
    }
}
