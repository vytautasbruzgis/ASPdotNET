using _20211230_IgnitisHomework_V2.Models;
using Microsoft.EntityFrameworkCore;

namespace _20211230_IgnitisHomework_V2.Data
{

    public class DataContext : DbContext
    {
        //public DbSet<ShopModel> Shops { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttributeOption>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Attribute>().HasKey(x => new { x.Id });
            modelBuilder.Entity<RegistrationAttribute>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Registration>().HasKey(x => new { x.Id });

            modelBuilder.Entity<Registration>().HasMany(x => x.Attributes).WithOne(x => x.Registration);
            modelBuilder.Entity<Attribute>().HasMany(x => x.Options).WithOne(x => x.Attribute);
            modelBuilder.Entity<RegistrationAttribute>().HasOne(x => x.Attribute).WithMany(x => x.RegistrationAttributes);

            modelBuilder.Entity<Attribute>().HasData(
                new Attribute()
                {
                    Id = 1,
                    Name = "Reikia atlikti rangos darbus",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 1,
                AttributeId = 1,
                Name = "Taip",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 2,
                AttributeId = 1,
                Name = "Ne",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });

            modelBuilder.Entity<Attribute>().HasData(
                new Attribute()
                {
                    Id = 2,
                    Name = "Rangos darbus atliks",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 3,
                AttributeId = 2,
                Name = "Metinis rangovas",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<Attribute>().HasData(
                new Attribute()
                {
                    Id = 3,
                    Name = "Verslo klientas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 4,
                AttributeId = 3,
                Name = "Taip",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 5,
                AttributeId = 3,
                Name = "Ne",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });

            modelBuilder.Entity<Attribute>().HasData(
                new Attribute()
                {
                    Id = 4,
                    Name = "Skaičiavimo metodas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 6,
                AttributeId = 4,
                Name = "Automatinis",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });

            modelBuilder.Entity<Attribute>().HasData(
                new Attribute()
                {
                    Id = 5,
                    Name = "Svarbus klientas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 7,
                AttributeId = 5,
                Name = "Taip",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 8,
                AttributeId = 5,
                Name = "Ne",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<AttributeOption>().HasData(
            new AttributeOption()
            {
                Id = 9,
                AttributeId = 5,
                Name = "",
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<RegistrationAttribute>().HasData(
            new RegistrationAttribute()
            {
                Id = 1,
                AttributeId = 1,
                RegistrationId = 1,
                SelectedOptionId = 1,
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<RegistrationAttribute>().HasData(
            new RegistrationAttribute()
            {
                Id = 2,
                AttributeId = 2,
                RegistrationId = 1,
                SelectedOptionId = 3,
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<RegistrationAttribute>().HasData(
            new RegistrationAttribute()
            {
                Id = 3,
                AttributeId = 3,
                RegistrationId = 1,
                SelectedOptionId = 5,
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<RegistrationAttribute>().HasData(
            new RegistrationAttribute()
            {
                Id = 4,
                AttributeId = 4,
                RegistrationId = 1,
                SelectedOptionId = 6,
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<RegistrationAttribute>().HasData(
            new RegistrationAttribute()
            {
                Id = 5,
                AttributeId = 5,
                RegistrationId = 1,
                SelectedOptionId = 7,
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
            modelBuilder.Entity<Registration>().HasData(
            new Registration()
            {
                Id = 1,
                Created = System.DateTime.Today,
                LastModified = System.DateTime.Today,
                IsDeleted = false
            });
        }
    }
}