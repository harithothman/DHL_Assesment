﻿// <auto-generated />
using DHLOne.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DHLOne.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240604094003_SeedItemTable")]
    partial class SeedItemTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DHLOne.Models.Item", b =>
                {
                    b.Property<int>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("itemId"));

                    b.Property<string>("itemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("itemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            itemId = 1,
                            itemDescription = "To hit things into the wall",
                            itemName = "Hammer"
                        },
                        new
                        {
                            itemId = 2,
                            itemDescription = "To call somebody",
                            itemName = "Phone"
                        },
                        new
                        {
                            itemId = 3,
                            itemDescription = "To hold water in place",
                            itemName = "Cup"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}