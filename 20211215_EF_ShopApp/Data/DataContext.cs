using _20211215_EF_ShopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace _20211215_FirstEFApp.Data
{

    public class DataContext : DbContext
    {
        public DbSet<ShopModel> Shops { get; set; }
        public DbSet<ShopItemModel> ShopItems { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopModel>().HasData(
                new ShopModel()
                {
                    Id = 1,
                    Name = "Shop 1"
                },
                 new ShopModel()
                 {
                     Id = 2,
                     Name = "Shop 2"
                 },
                new ShopModel()
                {
                    Id = 3,
                    Name = "Shop 3"
                });
            modelBuilder.Entity<ShopItemModel>().HasData(
                new ShopItemModel()
                {
                    Id = 1,
                    Name = "Item 1",
                    ExpiryDate = System.DateTime.Today,
                    ShopId = 1
                },
                //nepagaunu, kaip paseedinti shopitem su shopid
                 new ShopItemModel()
                 {
                     Id = 2,
                     Name = "Item 2",
                     ExpiryDate = System.DateTime.Today,
                     ShopId = 1
                 },
                new ShopItemModel()
                {
                    Id = 3,
                    Name = "Item 3",
                    ExpiryDate = System.DateTime.Today,
                    ShopId = 2
                    
                },
                new ShopItemModel()
                {
                    Id = 4,
                    Name = "Item 4",
                    ExpiryDate = System.DateTime.Today,
                    ShopId = 1
                },
                new ShopItemModel()
                {
                    Id = 5,
                    Name = "Item 5",
                    ExpiryDate = System.DateTime.Today,
                    ShopId = 1
                });
        }
    }
}