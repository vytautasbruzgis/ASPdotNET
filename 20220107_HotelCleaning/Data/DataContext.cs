using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;

namespace _20220107_HotelCleaning.Data
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
            modelBuilder.Entity<Hotel>().HasKey(x => new { x.Id});
            modelBuilder.Entity<Room>().HasKey(x => new { x.Id });
            modelBuilder.Entity<City>().HasKey(x => new { x.Id });
            modelBuilder.Entity<JobType>().HasKey(x => new { x.Id });
            modelBuilder.Entity<HotelTask>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Worker>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Visitor>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Person>().HasKey(x => new { x.Id });
            modelBuilder.Entity<TaskType>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Booking>().HasKey(x => new { x.Id });

            modelBuilder.Entity<Person>().HasOne(x => x.City);
            modelBuilder.Entity<Worker>().HasOne(x => x.Person);
            modelBuilder.Entity<Worker>().HasOne(x => x.JobType);
            modelBuilder.Entity<Visitor>().HasOne(x => x.Person);

            modelBuilder.Entity<Hotel>().HasOne(x => x.City);
            modelBuilder.Entity<Hotel>().HasMany(x => x.Rooms).WithOne(x => x.Hotel);
            modelBuilder.Entity<Room>().HasOne(x => x.Hotel);

            modelBuilder.Entity<HotelTask>().HasOne(x => x.Room).WithMany(x => x.Tasks);
            modelBuilder.Entity<HotelTask>().HasOne(x => x.Worker).WithMany(x => x.Tasks);
            modelBuilder.Entity<HotelTask>().HasOne(x => x.TaskType);

            modelBuilder.Entity<Booking>().HasOne(x => x.Room).WithMany(x => x.Bookings);
            modelBuilder.Entity<Booking>().HasOne(x => x.Visitor).WithMany(x => x.Bookings);

            modelBuilder.Entity<TaskType>().HasData(
                new TaskType()
                {
                    Id = 1,
                    Name = "Išvalyti kambarį",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<TaskType>().HasData(
                new TaskType()
                {
                    Id = 2,
                    Name = "Papildyti minibarą",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<JobType>().HasData(
                new JobType()
                {
                    Id = 1,
                    Name = "Kambarių valytojas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<JobType>().HasData(
                new JobType()
                {
                    Id = 2,
                    Name = "Restorano darbuotojas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<JobType>().HasData(
                new JobType()
                {
                    Id = 3,
                    Name = "Administratorius",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "Vilnius",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 2,
                    Name = "Kaunas",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 3,
                    Name = "Klaipėda",
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 1,
                    FirstName = "Vytautas",
                    LastName = "Bruzgis",
                    CityId = 1,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 2,
                    FirstName = "Anelė",
                    LastName = "Čirūnaitė",
                    CityId = 1,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "Radison SAS",
                    Address = "Konstitucijos pr. 5",
                    CityId = 1,
                    FloorsCount = 21,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 2,
                    Name = "Lietuva",
                    Address = "Šaligatvio g. 5",
                    CityId = 1,
                    FloorsCount = 16,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 3,
                    Name = "Daugirdas",
                    Address = "Kauno g. 5",
                    CityId = 2,
                    FloorsCount = 5,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });

            modelBuilder.Entity<Room>().HasData(
                new Room()
                {
                    Id = 1,
                    FloorNumber = 1,
                    RoomNumber = 101,
                    Name = "Karališkasis",
                    HotelId = 1,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
            modelBuilder.Entity<Room>().HasData(
                new Room()
                {
                    Id = 2,
                    FloorNumber = 1,
                    RoomNumber = 102,
                    Name = "Medaus puodynė",
                    HotelId = 1,
                    Created = System.DateTime.Today,
                    LastModified = System.DateTime.Today,
                    IsDeleted = false
                });
        }
    }
}