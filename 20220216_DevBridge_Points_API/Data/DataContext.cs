using _20220216_DevBridge_Points_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _20220216_DevBridge_Points_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext _dataContext;
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Point>().HasKey(x => new { x.Id });
            modelBuilder.Entity<PointList>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Square>().HasKey(x => new { x.Id });

            modelBuilder.Entity<Point>().HasOne(x => x.PointList).WithMany(y => y.Points);
            
            modelBuilder.Entity<PointList>().HasMany(x => x.Points).WithOne(x => x.PointList);
            modelBuilder.Entity<PointList>().HasMany(x => x.Squares).WithOne(x => x.PointList);
            modelBuilder.Entity<Square>().HasMany(x => x.Points).WithMany(x => x.Squares);
        }
    }
}
