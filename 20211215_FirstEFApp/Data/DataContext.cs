using _20211215_FirstEFApp.Models;
using Microsoft.EntityFrameworkCore;

namespace _20211215_FirstEFApp.Data
{
    
    public class DataContext: DbContext
    {
        public DbSet<ToDoModel> toDos { get; set; }
        public DbSet<CategoryModel> categories { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
    }
}
