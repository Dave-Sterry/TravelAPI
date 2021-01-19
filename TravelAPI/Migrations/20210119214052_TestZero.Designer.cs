﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20210119214052_TestZero")]
    partial class TestZero
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attraction");

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Attraction = "Boeing",
                            Name = "Renton",
                            Rating = 9
                        },
                        new
                        {
                            CityId = 2,
                            Attraction = "Powells",
                            Name = "Portland",
                            Rating = 8
                        },
                        new
                        {
                            CityId = 3,
                            Attraction = "Magic Gardens",
                            Name = "Philadelphia",
                            Rating = 8
                        },
                        new
                        {
                            CityId = 4,
                            Attraction = "North Eastern University",
                            Name = "Boston",
                            Rating = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
