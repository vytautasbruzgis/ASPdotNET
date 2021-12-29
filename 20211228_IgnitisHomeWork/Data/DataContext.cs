using _20211228_IgnitisHomeWork.Models;
using Microsoft.EntityFrameworkCore;

namespace _20211228_IgnitisHomeWork.Data
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
            modelBuilder.Entity<RegistrationattributesModel>().HasKey(x => new { x.Id});
            modelBuilder.Entity<ContractorTypeModel>().HasKey(x => new { x.Id });
            modelBuilder.Entity<CalculationTypeModel>().HasKey(x => new { x.Id });
            modelBuilder.Entity<CustomerImportanceModel>().HasKey(x => new { x.Id });

            modelBuilder.Entity<RegistrationattributesModel>().HasOne(x => x.ContractorType);
            modelBuilder.Entity<RegistrationattributesModel>().HasOne(x => x.CalculationType);
            modelBuilder.Entity<RegistrationattributesModel>().HasOne(x => x.CustomerImportance);

            modelBuilder.Entity<ContractorTypeModel>().HasData(
                new ContractorTypeModel()
                {
                    Id = 1,
                    Name = "Metinis rangovas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<CalculationTypeModel>().HasData(
                new CalculationTypeModel()
                {
                    Id = 1,
                    Name = "Automatinis",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<CustomerImportanceModel>().HasData(
                new CustomerImportanceModel()
                {
                    Id = 1,
                    Name = "",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<RegistrationattributesModel>().HasData(
                new RegistrationattributesModel()
                {
                    Id = 1,
                    HasContractWork = false,
                    ContractorTypeId = 1,
                    CalculationTypeId = 1,
                    IsBusinessClient = true,
                    CustomerImportanceId = 1
                });
        }
    }
}