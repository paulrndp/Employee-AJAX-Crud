﻿// <auto-generated />
using EmployeeAJAXCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeAJAXCrud.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220831072531_AddTable")]
    partial class AddTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EmployeeAJAXCrud.Models.Basic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("basics");
                });
#pragma warning restore 612, 618
        }
    }
}
