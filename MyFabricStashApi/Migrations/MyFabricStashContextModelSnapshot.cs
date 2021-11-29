﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFabricStashApi.Data;

namespace MyFabricStashApi.Migrations
{
    [DbContext(typeof(MyFabricStashContext))]
    partial class MyFabricStashContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFabricStashApi.Models.Fabric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccentColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AcquiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Collection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesignType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FabricContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FabricType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FabricWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("FatQtrQty")
                        .HasColumnType("bigint");

                    b.Property<string>("ImageFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("InitialPurchaseAmountPaid")
                        .HasColumnType("float");

                    b.Property<long?>("InitialPurchaseInches")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MainCategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SourceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SubCategoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalLengthInches")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalWidthInches")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Fabrics");
                });

            modelBuilder.Entity("MyFabricStashApi.Models.MainCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MainCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("MyFabricStashApi.Models.SubCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("MainCategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("MyFabricStashApi.Models.Fabric", b =>
                {
                    b.HasOne("MyFabricStashApi.Models.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId");

                    b.HasOne("MyFabricStashApi.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.Navigation("MainCategory");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("MyFabricStashApi.Models.SubCategory", b =>
                {
                    b.HasOne("MyFabricStashApi.Models.MainCategory", "MainCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("MyFabricStashApi.Models.MainCategory", b =>
                {
                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}