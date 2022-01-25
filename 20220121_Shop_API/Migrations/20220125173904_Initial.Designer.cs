﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _20220118_School_API.Data;

namespace _20220121_Shop_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220125173904_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_20220121_Shop_API.Models.Item", b =>
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Televizorius",
                            Price = 1099m
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Šaldytuvas",
                            Price = 499.5m
                        });
                });

            modelBuilder.Entity("_20220121_Shop_API.Models.Shop", b =>
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

                    b.ToTable("Shop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Akropolis"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Ozas"
                        });
                });

            modelBuilder.Entity("_20220121_Shop_API.Models.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            ItemId = 1,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Price = 499.5m,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            ItemId = 1,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Price = 489.5m,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            ItemId = 2,
                            LastModified = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Price = 1199.99m,
                            ShopId = 1
                        });
                });

            modelBuilder.Entity("_20220121_Shop_API.Models.ShopItem", b =>
                {
                    b.HasOne("_20220121_Shop_API.Models.Item", "Item")
                        .WithMany("ShopItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_20220121_Shop_API.Models.Shop", "Shop")
                        .WithMany("ShopItems")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("_20220121_Shop_API.Models.Item", b =>
                {
                    b.Navigation("ShopItems");
                });

            modelBuilder.Entity("_20220121_Shop_API.Models.Shop", b =>
                {
                    b.Navigation("ShopItems");
                });
#pragma warning restore 612, 618
        }
    }
}
