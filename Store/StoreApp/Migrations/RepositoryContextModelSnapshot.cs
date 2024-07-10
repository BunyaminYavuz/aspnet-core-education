﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 30000m,
                            ProductName = "Computer"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 3000m,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 800m,
                            ProductName = "Mouse"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 20000m,
                            ProductName = "Monitor"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 5000m,
                            ProductName = "Deck"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
