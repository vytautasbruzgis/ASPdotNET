// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _20220107_HotelCleaning.Data;

namespace _20220107_HotelCleaning.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220113172014_minor")]
    partial class minor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckedOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCheckedIn")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCheckedOut")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Vilnius"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Kaunas"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Klaipėda"
                        });
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FloorsCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomsInHotel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Konstitucijos pr. 5",
                            CityId = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FloorsCount = 21,
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Radison SAS",
                            RoomsInHotel = 0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Šaligatvio g. 5",
                            CityId = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FloorsCount = 16,
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Lietuva",
                            RoomsInHotel = 0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kauno g. 5",
                            CityId = 2,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FloorsCount = 5,
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Daugirdas",
                            RoomsInHotel = 0
                        });
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.HotelTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompleteUntil")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("TaskTypeId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("TaskTypeId");

                    b.HasIndex("WorkerId");

                    b.ToTable("HotelTask");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.JobType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Kambarių valytojas"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Restorano darbuotojas"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Administratorius"
                        });
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Vytautas",
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Bruzgis"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Anelė",
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Čirūnaitė"
                        });
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCheckedIn")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCleaned")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FloorNumber = 1,
                            HotelId = 1,
                            IsCheckedIn = false,
                            IsCleaned = true,
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Karališkasis",
                            RoomNumber = 101
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FloorNumber = 1,
                            HotelId = 1,
                            IsCheckedIn = false,
                            IsCleaned = true,
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Medaus puodynė",
                            RoomNumber = 102
                        });
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Išvalyti kambarį"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Papildyti minibarą"
                        });
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Visitor");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("JobTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Booking", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_20220107_HotelCleaning.Models.Visitor", "Visitor")
                        .WithMany("Bookings")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Hotel", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.HotelTask", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.Room", "Room")
                        .WithMany("Tasks")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_20220107_HotelCleaning.Models.TaskType", "TaskType")
                        .WithMany()
                        .HasForeignKey("TaskTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_20220107_HotelCleaning.Models.Worker", "Worker")
                        .WithMany("Tasks")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("TaskType");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Person", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Room", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Visitor", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Worker", b =>
                {
                    b.HasOne("_20220107_HotelCleaning.Models.JobType", "JobType")
                        .WithMany()
                        .HasForeignKey("JobTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_20220107_HotelCleaning.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Room", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Visitor", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("_20220107_HotelCleaning.Models.Worker", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
