using _20220118_School_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _20220118_School_API.Data
{
    public class DataContext: DbContext
    {
        public DataContext _dataContext;
        public DbSet<ToDo> ToDos { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
    }
}
