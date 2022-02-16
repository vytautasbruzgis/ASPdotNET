﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _20220216_DevBridge_Points_API.Data;

namespace _20220216_DevBridge_Points_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220216191325_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.Point", b =>
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

                    b.Property<int>("PointListId")
                        .HasColumnType("int");

                    b.Property<int?>("SquareId")
                        .HasColumnType("int");

                    b.Property<int>("X_Coordinate")
                        .HasColumnType("int");

                    b.Property<int>("Y_Coordinate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PointListId");

                    b.HasIndex("SquareId");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.PointList", b =>
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

                    b.ToTable("PointList");
                });

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.Square", b =>
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

                    b.Property<int>("PointListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PointListId");

                    b.ToTable("Square");
                });

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.Point", b =>
                {
                    b.HasOne("_20220216_DevBridge_Points_API.Models.PointList", "PointList")
                        .WithMany("Points")
                        .HasForeignKey("PointListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_20220216_DevBridge_Points_API.Models.Square", null)
                        .WithMany("Points")
                        .HasForeignKey("SquareId");

                    b.Navigation("PointList");
                });

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.Square", b =>
                {
                    b.HasOne("_20220216_DevBridge_Points_API.Models.PointList", "PointList")
                        .WithMany("Squares")
                        .HasForeignKey("PointListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PointList");
                });

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.PointList", b =>
                {
                    b.Navigation("Points");

                    b.Navigation("Squares");
                });

            modelBuilder.Entity("_20220216_DevBridge_Points_API.Models.Square", b =>
                {
                    b.Navigation("Points");
                });
#pragma warning restore 612, 618
        }
    }
}
