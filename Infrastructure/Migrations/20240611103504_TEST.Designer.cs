﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ElixirHandShopDBContext))]
    [Migration("20240611103504_TEST")]
    partial class TEST
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Identity.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique()
                        .HasFilter("[AppUserId] IS NOT NULL");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeliveryTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryTime = "1-2 Days",
                            Description = "Fastest delivery time",
                            Price = 10m,
                            ShortName = "UPS1"
                        },
                        new
                        {
                            Id = 2,
                            DeliveryTime = "2-5 Days",
                            Description = "Get it within 5 days",
                            Price = 5m,
                            ShortName = "UPS2"
                        },
                        new
                        {
                            Id = 3,
                            DeliveryTime = "5-10 Days",
                            Description = "Slower but cheap",
                            Price = 2m,
                            ShortName = "UPS3"
                        },
                        new
                        {
                            Id = 4,
                            DeliveryTime = "1-2 Weeks",
                            Description = "Free! You get what you pay for",
                            Price = 0m,
                            ShortName = "FREE"
                        });
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuyerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeliveryMethodId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PaymentIntentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipToAddressId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryMethodId");

                    b.HasIndex("ShipToAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ItemOrderedId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemOrderedId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.ProductItemOrdered", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductItemId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductItemOrdered");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductBrandId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "iPhone 12 Pro Max",
                            PictureUrl = "images/products/slide1.png",
                            Price = 200.00m,
                            ProductBrandId = 1,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "iPhone 12 Pro",
                            PictureUrl = "images/products/slide2.png",
                            Price = 150.00m,
                            ProductBrandId = 1,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "iPhone 12",
                            PictureUrl = "images/products/slide3.png",
                            Price = 180.00m,
                            ProductBrandId = 2,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "iPhone 11 Pro Max",
                            PictureUrl = "images/products/slide4.png",
                            Price = 300.00m,
                            ProductBrandId = 2,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "New Samsung Glaxy S",
                            PictureUrl = "images/products/slide5.png",
                            Price = 250.00m,
                            ProductBrandId = 4,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "New Huawei Pro Plus",
                            PictureUrl = "images/products/slide6.png",
                            Price = 120.00m,
                            ProductBrandId = 5,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "The largest, most advanced Always On Retina display. The most durable Apple Watch ever. Breakthrough health innovations. Up to 33 prec faster charging.",
                            Name = "Huawei Business Edition",
                            PictureUrl = "images/products/slide7.png",
                            Price = 10.00m,
                            ProductBrandId = 2,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Our most advanced dual camera system ever. An even brighter OLED display. A lightning fast chip that leaves the competition behind. A huge leap in battery life.",
                            Name = "Huawei Max",
                            PictureUrl = "images/products/slide8.png",
                            Price = 8.00m,
                            ProductBrandId = 4,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Our most advanced dual camera system ever. An even brighter OLED display. A lightning fast chip that leaves the competition behind. A huge leap in battery life.",
                            Name = "Xiaomi Ultra Pro",
                            PictureUrl = "images/products/slide9.png",
                            Price = 15.00m,
                            ProductBrandId = 4,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "Our most advanced dual camera system ever. An even brighter OLED display. A lightning fast chip that leaves the competition behind. A huge leap in battery life.",
                            Name = "Xiaomi Pro",
                            PictureUrl = "images/products/slide10.png",
                            Price = 18.00m,
                            ProductBrandId = 3,
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 11,
                            Description = "Our most advanced dual camera system ever. An even brighter OLED display. A lightning fast chip that leaves the competition behind. A huge leap in battery life.",
                            Name = "Oppo Business",
                            PictureUrl = "images/products/slide11.png",
                            Price = 15.00m,
                            ProductBrandId = 3,
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 12,
                            Description = "Our most advanced dual camera system ever. An even brighter OLED display. A slightning fast chip that leaves the competition behind. A huge leap in battery life.",
                            Name = "Nokia Plus pro",
                            PictureUrl = "images/products/slide12.png",
                            Price = 16.00m,
                            ProductBrandId = 4,
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 13,
                            Description = "Our most advanced dual camera system ever. An even brighter OLED display. A lightning fast chip that leaves the competition behind. A huge leap in battery life.",
                            Name = "Nokia Business Plus",
                            PictureUrl = "images/products/slide13.png",
                            Price = 14.00m,
                            ProductBrandId = 4,
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 14,
                            Description = "A dramatically more powerful camera system. An all new OLED display with ProMotion. The worlds fastest smartphone chip. A huge leap in battery life.",
                            Name = "Samsung Pro Max",
                            PictureUrl = "images/products/slide14.png",
                            Price = 250.00m,
                            ProductBrandId = 6,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            Description = "A dramatically more powerful camera system. An all new OLED display with ProMotion. The worlds fastest smartphone chip. A huge leap in battery life.",
                            Name = "Nokia Pro 9",
                            PictureUrl = "images/products/slide15.png",
                            Price = 189.99m,
                            ProductBrandId = 2,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 16,
                            Description = "A dramatically more powerful camera system. An all new OLED display with ProMotion. The worlds fastest smartphone chip. A huge leap in battery life.",
                            Name = "Samsung 8 Max",
                            PictureUrl = "images/products/slide16.png",
                            Price = 199.99m,
                            ProductBrandId = 2,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 17,
                            Description = "A dramatically more powerful camera system. An all new OLED display with ProMotion. The worlds fastest smartphone chip. A huge leap in battery life.",
                            Name = "Xiaomi X Pro",
                            PictureUrl = "images/products/slide17.png",
                            Price = 150.00m,
                            ProductBrandId = 1,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 18,
                            Description = "A dramatically more powerful camera system. An all new OLED display with ProMotion. The worlds fastest smartphone chip. A huge leap in battery life.",
                            Name = "Huawei 9S Pro ",
                            PictureUrl = "images/products/slide18.png",
                            Price = 180.00m,
                            ProductBrandId = 1,
                            ProductTypeId = 3
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "iPhone"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Huawei"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Oppo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Nokia"
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Max"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pro"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Plus"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Business"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Identity.UserAddress", b =>
                {
                    b.HasOne("Core.Entities.Identity.AppUser", "AppUser")
                        .WithOne("Address")
                        .HasForeignKey("Core.Entities.Identity.UserAddress", "AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Order", b =>
                {
                    b.HasOne("Core.Entities.OrderAggregate.DeliveryMethod", "DeliveryMethod")
                        .WithMany()
                        .HasForeignKey("DeliveryMethodId");

                    b.HasOne("Core.Entities.OrderAggregate.Address", "ShipToAddress")
                        .WithMany()
                        .HasForeignKey("ShipToAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryMethod");

                    b.Navigation("ShipToAddress");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.HasOne("Core.Entities.OrderAggregate.ProductItemOrdered", "ItemOrdered")
                        .WithMany()
                        .HasForeignKey("ItemOrderedId");

                    b.HasOne("Core.Entities.OrderAggregate.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.Navigation("ItemOrdered");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.HasOne("Core.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Core.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Identity.AppUser", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
