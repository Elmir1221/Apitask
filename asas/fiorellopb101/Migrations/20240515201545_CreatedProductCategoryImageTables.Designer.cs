﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fiorellopb101.Data;

#nullable disable

namespace fiorellopb101.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240515201545_CreatedProductCategoryImageTables")]
    partial class CreatedProductCategoryImageTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("fiorellopb101.Models.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CreatedDate = new DateTime(2024, 5, 16, 0, 15, 45, 195, DateTimeKind.Local).AddTicks(1104),
                            Description = "Resadin Blogu",
                            Image = "blog-feature-img-1.jpg",
                            SoftDeleted = false,
                            Title = "REsadin Blogu"
                        },
                        new
                        {
                            id = 2,
                            CreatedDate = new DateTime(2024, 5, 16, 0, 15, 45, 195, DateTimeKind.Local).AddTicks(1106),
                            Description = "Resadin Blogu",
                            Image = "blog-feature-img-2.jpg",
                            SoftDeleted = false,
                            Title = "Behruzun Blogu"
                        },
                        new
                        {
                            id = 3,
                            CreatedDate = new DateTime(2024, 5, 16, 0, 15, 45, 195, DateTimeKind.Local).AddTicks(1106),
                            Description = "Ilqarin Blogu",
                            Image = "blog-feature-img-3.jpg",
                            SoftDeleted = false,
                            Title = "Ilqarin Blogu"
                        });
                });

            modelBuilder.Entity("fiorellopb101.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("fiorellopb101.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("fiorellopb101.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("fiorellopb101.Models.Slider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("fiorellopb101.Models.SliderInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.ToTable("SliderInfo");
                });

            modelBuilder.Entity("fiorellopb101.Models.Product", b =>
                {
                    b.HasOne("fiorellopb101.Models.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("fiorellopb101.Models.ProductImage", b =>
                {
                    b.HasOne("fiorellopb101.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("fiorellopb101.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("fiorellopb101.Models.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
