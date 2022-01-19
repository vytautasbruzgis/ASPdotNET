using _20210118_School_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _20220118_School_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext _dataContext;
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Student>().HasKey(x => new { x.Id });

            modelBuilder.Entity<School>().HasMany(x => x.Students).WithOne(y => y.School);
            modelBuilder.Entity<Student>().HasOne(x => x.School).WithMany(x => x.Students);


            modelBuilder.Entity<School>().HasData(
                new School()
                {
                    Id = 1,
                    Title = "Vilniaus Užupio gimnazija",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Vytautas",
                    LastName = "Bruzgis",
                    Sex = "Male",
                    SchoolId = 1,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
        }
    }
}
