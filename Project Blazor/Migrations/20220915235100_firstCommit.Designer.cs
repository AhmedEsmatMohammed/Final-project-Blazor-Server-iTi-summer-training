﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Blazor.DBContext;

#nullable disable

namespace Project_Blazor.Migrations
{
    [DbContext(typeof(ProductDB))]
    [Migration("20220915235100_firstCommit")]
    partial class firstCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project_Blazor.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Project_Blazor.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Project_Blazor.Models.Order", b =>
                {
                    b.Property<int>("Idd_prod")
                        .HasColumnType("int");

                    b.Property<int>("Idd_cust")
                        .HasColumnType("int");

                    b.Property<int>("QTY")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date")
                        .HasColumnType("date");

                    b.HasKey("Idd_prod", "Idd_cust");

                    b.HasIndex("Idd_cust");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project_Blazor.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Project_Blazor.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Project_Blazor.Models.Order", b =>
                {
                    b.HasOne("Project_Blazor.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("Idd_cust")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Blazor.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("Idd_prod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project_Blazor.Models.Product", b =>
                {
                    b.HasOne("Project_Blazor.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Project_Blazor.Models.SubCategory", b =>
                {
                    b.HasOne("Project_Blazor.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project_Blazor.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Project_Blazor.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Project_Blazor.Models.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Project_Blazor.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}