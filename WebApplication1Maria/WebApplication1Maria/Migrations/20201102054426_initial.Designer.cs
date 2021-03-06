﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1Maria.Data;

namespace WebApplication1Maria.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201102054426_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1Maria.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmpAddress");

                    b.Property<string>("EmpName");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
