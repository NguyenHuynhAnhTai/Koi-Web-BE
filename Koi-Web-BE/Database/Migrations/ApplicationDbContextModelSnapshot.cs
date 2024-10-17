﻿// <auto-generated />
using System;
using Koi_Web_BE.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Koi_Web_BE.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FarmKoiId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("FarmKoiId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("KoiId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KoiId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Farm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.FarmImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FarmId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("FarmImages");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.FarmKoi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FarmId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("KoiId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.HasIndex("KoiId");

                    b.ToTable("FarmKois");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Koi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsMale")
                        .HasColumnType("boolean");

                    b.Property<decimal>("MaxSize")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MinSize")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("SpeciesId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Kois");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.KoiImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("KoiId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KoiId");

                    b.ToTable("KoiImages");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FarmId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("boolean");

                    b.Property<long>("PayOSOrderCode")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.OrderKoi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("KoiId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("KoiId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderKois");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.OrderTrip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderTrips");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("FarmId")
                        .HasColumnType("uuid");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Species", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DiscoveredBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("YearOfDiscovery")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Cart", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.User", "User")
                        .WithOne("Carts")
                        .HasForeignKey("Koi_Web_BE.Models.Entities.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.CartItem", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koi_Web_BE.Models.Entities.FarmKoi", "FarmKoi")
                        .WithMany("CartItems")
                        .HasForeignKey("FarmKoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("FarmKoi");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Color", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Koi", "Koi")
                        .WithMany("Colors")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Koi");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.FarmImage", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Farm", "Farm")
                        .WithMany("FarmImages")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.FarmKoi", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Farm", "Farm")
                        .WithMany("FarmKois")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koi_Web_BE.Models.Entities.Koi", "Koi")
                        .WithMany("FarmKois")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");

                    b.Navigation("Koi");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Koi", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Species", "Species")
                        .WithMany("Kois")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.KoiImage", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Koi", "Koi")
                        .WithMany("Images")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Koi");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Order", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Farm", "Farm")
                        .WithMany("Orders")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koi_Web_BE.Models.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.OrderKoi", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Koi", "Koi")
                        .WithMany("OrderKois")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koi_Web_BE.Models.Entities.Order", "Order")
                        .WithMany("OrderKois")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Koi");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.OrderTrip", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Order", "Order")
                        .WithOne("OrderTrip")
                        .HasForeignKey("Koi_Web_BE.Models.Entities.OrderTrip", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Review", b =>
                {
                    b.HasOne("Koi_Web_BE.Models.Entities.Farm", "Farm")
                        .WithMany("Reviews")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koi_Web_BE.Models.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Farm", b =>
                {
                    b.Navigation("FarmImages");

                    b.Navigation("FarmKois");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.FarmKoi", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Koi", b =>
                {
                    b.Navigation("Colors");

                    b.Navigation("FarmKois");

                    b.Navigation("Images");

                    b.Navigation("OrderKois");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Order", b =>
                {
                    b.Navigation("OrderKois");

                    b.Navigation("OrderTrip")
                        .IsRequired();
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.Species", b =>
                {
                    b.Navigation("Kois");
                });

            modelBuilder.Entity("Koi_Web_BE.Models.Entities.User", b =>
                {
                    b.Navigation("Carts")
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
