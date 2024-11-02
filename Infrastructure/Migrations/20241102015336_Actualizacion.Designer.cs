﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241102015336_Actualizacion")]
    partial class Actualizacion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SellerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusOrder")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Entities.OrderNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderNotifications");
                });

            modelBuilder.Entity("Domain.Entities.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrdersProducts");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("ProductAvaible")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Talle L color blanco",
                            Name = "Remera",
                            Price = 100.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA111",
                            Stock = 500
                        },
                        new
                        {
                            Id = 2,
                            Description = "Talle 44 jean",
                            Name = "Pantalon",
                            Price = 200.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA222",
                            Stock = 300
                        },
                        new
                        {
                            Id = 3,
                            Description = "Talle 40 de color negro",
                            Name = "Zapatos",
                            Price = 300.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA333",
                            Stock = 400
                        },
                        new
                        {
                            Id = 4,
                            Description = "Talle 38 de color blanco",
                            Name = "Zapatos",
                            Price = 400.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA444",
                            Stock = 1500
                        },
                        new
                        {
                            Id = 5,
                            Description = "Talle 36 de color marron",
                            Name = "Zapatos",
                            Price = 350.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA888",
                            Stock = 1000
                        },
                        new
                        {
                            Id = 6,
                            Description = "Talle XL de color azul",
                            Name = "Buzo",
                            Price = 500.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA555",
                            Stock = 900
                        },
                        new
                        {
                            Id = 7,
                            Description = "Talle L de color blanco",
                            Name = "Buzo",
                            Price = 500.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA666",
                            Stock = 750
                        },
                        new
                        {
                            Id = 8,
                            Description = "Talle 40 marca Nike",
                            Name = "Zapatillas",
                            Price = 350.00m,
                            ProductAvaible = true,
                            ProductCode = "AAA777",
                            Stock = 1200
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Avaible")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime");

                    b.Property<int>("UserType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avaible = true,
                            Email = "gaston.koch@hotmail.com",
                            LastName = "Koch",
                            Name = "Gaston",
                            Password = "g",
                            RegisterDate = new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 1
                        },
                        new
                        {
                            Id = 2,
                            Avaible = true,
                            Email = "pepe@gmail.com",
                            LastName = "Gomez",
                            Name = "Pepe",
                            Password = "2",
                            RegisterDate = new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 0
                        },
                        new
                        {
                            Id = 3,
                            Avaible = true,
                            Email = "juan@gmail.com",
                            LastName = "Gomez",
                            Name = "Juan",
                            Password = "3",
                            RegisterDate = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 1
                        },
                        new
                        {
                            Id = 4,
                            Avaible = true,
                            Email = "ana@gmail.com",
                            LastName = "Lopez",
                            Name = "Ana",
                            Password = "4",
                            RegisterDate = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 0
                        },
                        new
                        {
                            Id = 5,
                            Avaible = true,
                            Email = "luis@gmail.com",
                            LastName = "Franco",
                            Name = "Luis",
                            Password = "123",
                            RegisterDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 1
                        },
                        new
                        {
                            Id = 6,
                            Avaible = true,
                            Email = "pepe@gmail.com",
                            LastName = "Moscheti",
                            Name = "Pepe",
                            Password = "876",
                            RegisterDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 1
                        },
                        new
                        {
                            Id = 7,
                            Avaible = true,
                            Email = "admin@ecommerce.com",
                            LastName = "",
                            Name = "admin",
                            Password = "admin",
                            RegisterDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 2
                        },
                        new
                        {
                            Id = 8,
                            Avaible = true,
                            Email = "luisG@hotmail.com",
                            LastName = "Guevara",
                            Name = "Luis",
                            Password = "433",
                            RegisterDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Domain.Entities.OrderNotification", b =>
                {
                    b.HasOne("Domain.Entities.Order", "Order")
                        .WithMany("OrderNotifications")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("OrderNotifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.OrderProduct", b =>
                {
                    b.HasOne("Domain.Entities.Order", "Order")
                        .WithMany("ProductsInOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderNotifications");

                    b.Navigation("ProductsInOrder");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("OrderNotifications");
                });
#pragma warning restore 612, 618
        }
    }
}
