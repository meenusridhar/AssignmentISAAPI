﻿// <auto-generated />
using AssignmentISAAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssignmentISAAPI.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20221102113824_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmentISAAPI.Model.HotelDetail", b =>
                {
                    b.Property<int>("HotelCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Currency")
                        .HasColumnType("float");

                    b.Property<string>("HotelDescriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("StarLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalRate")
                        .HasColumnType("float");

                    b.Property<string>("hotelMainImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("policiesAndDisclaimer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelCode");

                    b.ToTable("HotelDetails");
                });
#pragma warning restore 612, 618
        }
    }
}