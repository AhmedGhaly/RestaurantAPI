﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantAPI.Models;

#nullable disable

namespace RestaurantAPI.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("RestaurantAPI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("RestaurantAPI.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("ResturantId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("ResturantId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Cateigory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cateigorys");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Copon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumberOfUser")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Copons");
                });

            modelBuilder.Entity("RestaurantAPI.Models.DeliveryMan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResturantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResturantId");

                    b.ToTable("DeliveryMen");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeliveryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("DeliveryMethod")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasFilter("[AddressId] IS NOT NULL");

                    b.HasIndex("CartId")
                        .IsUnique();

                    b.HasIndex("DeliveryId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Recipe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("restaurantId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("restaurantId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RestaurantAPI.Models.RecipeFeedback", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("userId");

                    b.ToTable("RecipeFeedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Models.RecipeImage", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RecipeId", "Image");

                    b.ToTable("RecipeImages");
                });

            modelBuilder.Entity("RestaurantAPI.Models.RestaurantCateigory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantCateigories");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Resturant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cusinetype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OpenHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Resturants");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ResturantFeature", b =>
                {
                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int>("ResturantId")
                        .HasColumnType("int");

                    b.HasKey("FeatureId", "ResturantId");

                    b.HasIndex("ResturantId");

                    b.ToTable("ResturantFeatures");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ResturantFeedback", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ResturantId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ResturantId");

                    b.HasIndex("UserId");

                    b.ToTable("ResturantFeedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableState")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("ResturantId")
                        .HasColumnType("int");

                    b.Property<int>("TableType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResturantId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("RestaurantAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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

                    b.Property<int>("table_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("table_id")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);
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
                    b.HasOne("RestaurantAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RestaurantAPI.Models.User", null)
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

                    b.HasOne("RestaurantAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RestaurantAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantAPI.Models.Cart", b =>
                {
                    b.HasOne("RestaurantAPI.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("RestaurantAPI.Models.CartItem", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.Resturant", "Resturant")
                        .WithMany()
                        .HasForeignKey("ResturantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Recipe");

                    b.Navigation("Resturant");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Copon", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Order", "Order")
                        .WithOne("copon")
                        .HasForeignKey("RestaurantAPI.Models.Copon", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantAPI.Models.DeliveryMan", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Resturant", "Resturant")
                        .WithMany("DeliveryMen")
                        .HasForeignKey("ResturantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resturant");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Order", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Address", "Address")
                        .WithOne("Orders")
                        .HasForeignKey("RestaurantAPI.Models.Order", "AddressId");

                    b.HasOne("RestaurantAPI.Models.Cart", "Cart")
                        .WithOne("order")
                        .HasForeignKey("RestaurantAPI.Models.Order", "CartId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.DeliveryMan", "Deliveryman")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Cart");

                    b.Navigation("Deliveryman");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Recipe", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Cateigory", "Cateigory")
                        .WithMany("Recipes")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.Resturant", "restaurant")
                        .WithMany("Recipes")
                        .HasForeignKey("restaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cateigory");

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("RestaurantAPI.Models.RecipeFeedback", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Recipe", "Recipe")
                        .WithMany("RecipeFeedbacks")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.User", "user")
                        .WithMany("RecipeFeedbacks")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("user");
                });

            modelBuilder.Entity("RestaurantAPI.Models.RecipeImage", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Recipe", "Recipe")
                        .WithMany("recipteImages")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RestaurantAPI.Models.RestaurantCateigory", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Cateigory", "Cateigory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.Resturant", "Resturant")
                        .WithMany("Cateigories")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cateigory");

                    b.Navigation("Resturant");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ResturantFeature", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Feature", "Feature")
                        .WithMany("ResturantFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.Resturant", "Resturant")
                        .WithMany("ResturantFeatures")
                        .HasForeignKey("ResturantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Resturant");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ResturantFeedback", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Resturant", "Resturant")
                        .WithMany("resturantFeedbacks")
                        .HasForeignKey("ResturantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.User", "User")
                        .WithMany("ResturantFeedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resturant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Table", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Resturant", "Resturant")
                        .WithMany("Tables")
                        .HasForeignKey("ResturantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resturant");
                });

            modelBuilder.Entity("RestaurantAPI.Models.User", b =>
                {
                    b.HasOne("RestaurantAPI.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.Table", "table")
                        .WithOne("user")
                        .HasForeignKey("RestaurantAPI.Models.User", "table_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("table");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Address", b =>
                {
                    b.Navigation("Orders")
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantAPI.Models.Cart", b =>
                {
                    b.Navigation("order");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Cateigory", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("RestaurantAPI.Models.DeliveryMan", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Feature", b =>
                {
                    b.Navigation("ResturantFeatures");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Order", b =>
                {
                    b.Navigation("copon");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Recipe", b =>
                {
                    b.Navigation("RecipeFeedbacks");

                    b.Navigation("recipteImages");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Resturant", b =>
                {
                    b.Navigation("Cateigories");

                    b.Navigation("DeliveryMen");

                    b.Navigation("Recipes");

                    b.Navigation("ResturantFeatures");

                    b.Navigation("Tables");

                    b.Navigation("resturantFeedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Models.Table", b =>
                {
                    b.Navigation("user");
                });

            modelBuilder.Entity("RestaurantAPI.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("RecipeFeedbacks");

                    b.Navigation("ResturantFeedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
