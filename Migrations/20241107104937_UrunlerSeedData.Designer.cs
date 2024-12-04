﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreWeb.Models;

#nullable disable

namespace StoreWeb.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20241107104937_UrunlerSeedData")]
    partial class UrunlerSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1");

            modelBuilder.Entity("StoreWeb.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 25450.0,
                            ProductName = "Computer"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 11600.0,
                            ProductName = "Monitor"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 2999.9899999999998,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 2657.8499999999999,
                            ProductName = "Mouse"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 3999.9899999999998,
                            ProductName = "Hoparlor"
                        },
                        new
                        {
                            ProductId = 6,
                            Price = 1199.0,
                            ProductName = "Printer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
