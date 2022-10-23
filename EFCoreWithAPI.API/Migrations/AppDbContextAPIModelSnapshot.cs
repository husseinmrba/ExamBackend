﻿// <auto-generated />
using EFCoreWithAPI.API.DbContextAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreWithAPI.API.Migrations
{
    [DbContext(typeof(AppDbContextAPI))]
    partial class AppDbContextAPIModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreWithAPI.API.Controllers.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Hussein",
                            LastName = "Issa",
                            Score = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hasan",
                            LastName = "Issa",
                            Score = 80.0
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Ramiz",
                            LastName = "Issa",
                            Score = 85.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}