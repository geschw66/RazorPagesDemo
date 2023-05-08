﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesUI.Models;

namespace RazorPagesUI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230508024400_SeedListOfRecords")]
    partial class SeedListOfRecords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesUI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "University City",
                            State = "MO",
                            StreetAddress = "8822 Delmar Blvd",
                            ZipCode = "63124"
                        },
                        new
                        {
                            Id = 2,
                            City = "Mockingbird Heights",
                            State = "NH",
                            StreetAddress = "1313 MockingBird Lane",
                            ZipCode = "30123"
                        },
                        new
                        {
                            Id = 3,
                            City = "Edwardsville",
                            State = "IL",
                            StreetAddress = "425 Grandview Dr.",
                            ZipCode = "62025"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
