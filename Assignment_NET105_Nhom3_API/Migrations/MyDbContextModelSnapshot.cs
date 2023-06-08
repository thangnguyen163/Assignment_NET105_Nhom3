﻿// <auto-generated />
using System;
using Assignment_NET105_Nhom3_API.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_NET105_Nhom3_API.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bill", (string)null);
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.BillDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ComboId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProductDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ComboId");

                    b.HasIndex("ProductDetailsId");

                    b.ToTable("BillDetails", (string)null);
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Cart", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.CartDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ComboId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ComboId");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("UserId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.ComboDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ComboId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComboId");

                    b.HasIndex("ProductsDetailsId");

                    b.ToTable("ComboDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Combos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.ProductDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvaiableQuatity")
                        .HasColumnType("int");

                    b.Property<Guid?>("ColorId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SizeId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Products", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Bill", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Customer", "Customer")
                        .WithMany("Bill")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.BillDetails", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_NET105_Nhom3.Models.Combos", "Combos")
                        .WithMany("BillDetails")
                        .HasForeignKey("ComboId");

                    b.HasOne("Assignment_NET105_Nhom3.Models.ProductDetails", "ProductDetails")
                        .WithMany("BillDetails")
                        .HasForeignKey("ProductDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Combos");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.CartDetails", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Combos", "Combos")
                        .WithMany("CartDetails")
                        .HasForeignKey("ComboId");

                    b.HasOne("Assignment_NET105_Nhom3.Models.ProductDetails", "ProductDetails")
                        .WithMany("CartDetails")
                        .HasForeignKey("ProductDetailId");

                    b.HasOne("Assignment_NET105_Nhom3.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Combos");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.ComboDetails", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Combos", "Combos")
                        .WithMany("ComboDetails")
                        .HasForeignKey("ComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_NET105_Nhom3.Models.ProductDetails", "ProductDetails")
                        .WithMany("ComboDetails")
                        .HasForeignKey("ProductsDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combos");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Combos", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Category", "Category")
                        .WithMany("Combos")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Customer", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Cart", "Cart")
                        .WithOne("Customer")
                        .HasForeignKey("Assignment_NET105_Nhom3.Models.Customer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_NET105_Nhom3.Models.Role", "Role")
                        .WithMany("Customer")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.ProductDetails", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Color", "Color")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_NET105_Nhom3.Models.Products", "Products")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId");

                    b.HasOne("Assignment_NET105_Nhom3.Models.Size", "Size")
                        .WithMany("ProductDetails")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Products");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Products", b =>
                {
                    b.HasOne("Assignment_NET105_Nhom3.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Category", b =>
                {
                    b.Navigation("Combos");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Color", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Combos", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");

                    b.Navigation("ComboDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Customer", b =>
                {
                    b.Navigation("Bill");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.ProductDetails", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");

                    b.Navigation("ComboDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Products", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Role", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Assignment_NET105_Nhom3.Models.Size", b =>
                {
                    b.Navigation("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
