using _20220209_School_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _20220209_School_API.Data
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
            modelBuilder.Entity<School>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Student>().HasKey(x => new { x.Id });

            modelBuilder.Entity<School>().HasMany(x => x.Students).WithOne(y => y.School);
            modelBuilder.Entity<Student>().HasOne(x => x.School).WithMany(x => x.Students);


            //modelBuilder.Entity<Shop>().HasData(
            //    new Shop()
            //    {
            //        Id = 1,
            //        Name = "Akropolis",
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });
            //modelBuilder.Entity<Shop>().HasData(
            //    new Shop()
            //    {
            //        Id = 2,
            //        Name = "Ozas",
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });

            //modelBuilder.Entity<Item>().HasData(
            //    new Item()
            //    {
            //        Id = 1,
            //        Name = "Televizorius",
            //        Price = (decimal)1099.00,
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });
            //modelBuilder.Entity<Item>().HasData(
            //    new Item()
            //    {
            //        Id = 2,
            //        Name = "Šaldytuvas",
            //        Price = (decimal)499.50,
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });
            //modelBuilder.Entity<ShopItem>().HasData(
            //    new ShopItem()
            //    {
            //        Id = 1,
            //        ShopId = 1,
            //        ItemId = 1,
            //        Price = (decimal)499.50,
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });
            //modelBuilder.Entity<ShopItem>().HasData(
            //    new ShopItem()
            //    {
            //        Id = 2,
            //        ShopId = 2,
            //        ItemId = 1,
            //        Price = (decimal)489.50,
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });
            //modelBuilder.Entity<ShopItem>().HasData(
            //    new ShopItem()
            //    {
            //        Id = 3,
            //        ShopId = 1,
            //        ItemId = 2,
            //        Price = (decimal)1199.99,
            //        Created = System.DateTime.Today,
            //        LastModified = System.DateTime.Today,
            //        IsDeleted = false
            //    });
        }
    }
}
