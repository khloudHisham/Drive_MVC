﻿// <auto-generated />
using MVCDay2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCDay2.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240129163404_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCDay2.Models.CRSresult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CrsDegree")
                        .HasColumnType("int");

                    b.Property<int>("TRId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TRId");

                    b.ToTable("CRSresults");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            CrsDegree = 100,
                            TRId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            CrsDegree = 200,
                            TRId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            CrsDegree = 40,
                            TRId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            CrsDegree = 10,
                            TRId = 4
                        });
                });

            modelBuilder.Entity("MVCDay2.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseDegree")
                        .HasColumnType("int");

                    b.Property<int>("CourseMinDegree")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseDegree = 40,
                            CourseMinDegree = 20,
                            CourseName = "DB",
                            DeptId = 2
                        },
                        new
                        {
                            Id = 2,
                            CourseDegree = 60,
                            CourseMinDegree = 10,
                            CourseName = "DotNot",
                            DeptId = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseDegree = 80,
                            CourseMinDegree = 20,
                            CourseName = "Js",
                            DeptId = 3
                        });
                });

            modelBuilder.Entity("MVCDay2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeptManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeptManager = "Amr",
                            DeptName = "NETdept"
                        },
                        new
                        {
                            Id = 2,
                            DeptManager = "Amira",
                            DeptName = "DBdept"
                        },
                        new
                        {
                            Id = 3,
                            DeptManager = "Ahmed",
                            DeptName = "JSdept"
                        });
                });

            modelBuilder.Entity("MVCDay2.Models.Instractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("InsAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("InsSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("DeptId");

                    b.ToTable("Instractors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 3,
                            DeptId = 1,
                            InsAddress = "cairo",
                            InsImage = "mal.jpeg",
                            InsName = "Omer",
                            InsSalary = 5000m
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            DeptId = 2,
                            InsAddress = "cairo",
                            InsImage = "mal.jpeg",
                            InsName = "hasan",
                            InsSalary = 9000m
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1,
                            DeptId = 3,
                            InsAddress = "alex",
                            InsImage = "fem.jpeg",
                            InsName = "reem",
                            InsSalary = 6000m
                        });
                });

            modelBuilder.Entity("MVCDay2.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("TrAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrGrade")
                        .HasColumnType("int");

                    b.Property<string>("TrImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Trainees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeptId = 1,
                            TrAddress = "cairo",
                            TrGrade = 50,
                            TrImage = "mal.jpeg",
                            TrName = "hosam"
                        },
                        new
                        {
                            Id = 2,
                            DeptId = 2,
                            TrAddress = "alex",
                            TrGrade = 90,
                            TrImage = "fem.jpeg",
                            TrName = "hager"
                        },
                        new
                        {
                            Id = 3,
                            DeptId = 3,
                            TrAddress = "cairo",
                            TrGrade = 20,
                            TrImage = "mal.jpeg",
                            TrName = "hithem"
                        },
                        new
                        {
                            Id = 4,
                            DeptId = 2,
                            TrAddress = "alex",
                            TrGrade = 170,
                            TrImage = "fem.jpeg",
                            TrName = "hoda"
                        });
                });

            modelBuilder.Entity("MVCDay2.Models.CRSresult", b =>
                {
                    b.HasOne("MVCDay2.Models.Course", "Course")
                        .WithMany("CRSresults")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDay2.Models.Trainee", "Trainee")
                        .WithMany("CRS")
                        .HasForeignKey("TRId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("MVCDay2.Models.Course", b =>
                {
                    b.HasOne("MVCDay2.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVCDay2.Models.Instractor", b =>
                {
                    b.HasOne("MVCDay2.Models.Course", "Course")
                        .WithMany("Instractors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDay2.Models.Department", "Department")
                        .WithMany("Instractors")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVCDay2.Models.Trainee", b =>
                {
                    b.HasOne("MVCDay2.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVCDay2.Models.Course", b =>
                {
                    b.Navigation("CRSresults");

                    b.Navigation("Instractors");
                });

            modelBuilder.Entity("MVCDay2.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instractors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("MVCDay2.Models.Trainee", b =>
                {
                    b.Navigation("CRS");
                });
#pragma warning restore 612, 618
        }
    }
}
