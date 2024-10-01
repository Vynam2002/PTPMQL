﻿// <auto-generated />
using DEMOData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CRUD.Models.Employee", b =>
                {
                    b.Property<int>("Tuoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Tuoi");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DEMO.Models.Person", b =>
                {
                    b.Property<int>("CCCD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HOTEN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QUEQUAN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CCCD");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
