﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo.contexts;

#nullable disable

namespace demo.contexts.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20250223232959_ManyToManyRelationship")]
    partial class ManyToManyRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int>("coursesId")
                        .HasColumnType("int");

                    b.HasKey("StudentsId", "coursesId");

                    b.HasIndex("coursesId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("demo.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("demo.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DepName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("empId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("empId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("demo.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EmpName");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.Property<int?>("workforID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("workforID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("demo.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("demo.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("demo.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("coursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("demo.Models.Department", b =>
                {
                    b.HasOne("demo.Models.Employee", "Manager")
                        .WithOne("department")
                        .HasForeignKey("demo.Models.Department", "empId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("demo.Models.Employee", b =>
                {
                    b.HasOne("demo.Models.Department", "workfor")
                        .WithMany("employee")
                        .HasForeignKey("workforID");

                    b.Navigation("workfor");
                });

            modelBuilder.Entity("demo.Models.Department", b =>
                {
                    b.Navigation("employee");
                });

            modelBuilder.Entity("demo.Models.Employee", b =>
                {
                    b.Navigation("department");
                });
#pragma warning restore 612, 618
        }
    }
}
