﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230720112112_start")]
    partial class start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Book"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Electronic"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            ImageUrl = "/images/1.jpg",
                            Price = 27000m,
                            ProductName = "Computer",
                            Summary = ""
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            ImageUrl = "/images/2.jpg",
                            Price = 1500m,
                            ProductName = "Keyboard",
                            Summary = ""
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ImageUrl = "/images/3.jpg",
                            Price = 1000m,
                            ProductName = "Mouse",
                            Summary = ""
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ImageUrl = "/images/4.jpg",
                            Price = 5000m,
                            ProductName = "Monitor",
                            Summary = ""
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ImageUrl = "/images/5.jpg",
                            Price = 2000m,
                            ProductName = "Deck",
                            Summary = ""
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            ImageUrl = "/images/6.jpg",
                            Price = 150m,
                            ProductName = "History",
                            Summary = ""
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            ImageUrl = "/images/7.jpg",
                            Price = 200m,
                            ProductName = "LOTR",
                            Summary = ""
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
