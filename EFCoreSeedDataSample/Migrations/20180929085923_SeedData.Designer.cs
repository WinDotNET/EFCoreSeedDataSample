﻿// <auto-generated />
using System;
using EFCoreSeedDataSample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreSeedDataSample.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20180929085923_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreSeedDataSample.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new { Id = new Guid("c4e27fc0-8d63-4ffb-8fb1-60225dec9e7a"), Name = "Stu 1" },
                        new { Id = new Guid("9ac6a7be-8bc5-4271-98e0-672dd35bb85d"), Name = "Stu 2" },
                        new { Id = new Guid("72dab05d-5c6b-43e0-8ec0-3ecd0552a27d"), Name = "Stu 3" },
                        new { Id = new Guid("07cbf7c5-08ce-45a6-be8b-d83895edc56c"), Name = "Stu 4" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}