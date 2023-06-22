﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityManagement.Entities.Data;

#nullable disable

namespace UniversityManagement.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniversityManagement.Entities.Models.Class", b =>
                {
                    b.Property<int>("IdClass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClass"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("IdDeparment")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearOfAdmission")
                        .HasColumnType("datetime2");

                    b.HasKey("IdClass");

                    b.HasIndex("IdDeparment");

                    b.ToTable("Class");

                    b.HasData(
                        new
                        {
                            IdClass = 1,
                            Amount = 75,
                            IdDeparment = 1,
                            Name = "Cong nghe thong tin 1",
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.ClassRoom", b =>
                {
                    b.Property<int>("IdClassRoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClassRoom"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClassRoom");

                    b.ToTable("ClassRoom");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Deparment", b =>
                {
                    b.Property<int>("IdDeparment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDeparment"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDeparment");

                    b.ToTable("Deparment");

                    b.HasData(
                        new
                        {
                            IdDeparment = 1,
                            Name = "Cong Nghe Thong Tin"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Student", b =>
                {
                    b.Property<int>("IdClass")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdClass");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            IdClass = 1,
                            Address = "Ha Noi",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdStudent = 1,
                            Name = "Nguyen Duc Bao Son"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject", b =>
                {
                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherIdTeacher")
                        .HasColumnType("int");

                    b.HasKey("IdSubject");

                    b.HasIndex("TeacherIdTeacher");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Score", b =>
                {
                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.HasKey("IdSubject", "IdStudent");

                    b.HasIndex("IdStudent");

                    b.ToTable("Subject_Scores");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Student", b =>
                {
                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.HasKey("IdSubject", "IdStudent");

                    b.HasIndex("IdStudent");

                    b.ToTable("Subject_Student");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Teacher", b =>
                {
                    b.Property<int>("IdTeacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTeacher"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTeacher");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Class", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Deparment", "Deparment")
                        .WithMany("Classes")
                        .HasForeignKey("IdDeparment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deparment");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Student", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("IdClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.ClassRoom", "ClassRoom")
                        .WithOne("Subject")
                        .HasForeignKey("UniversityManagement.Entities.Models.Subject", "IdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityManagement.Entities.Models.Teacher", null)
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherIdTeacher");

                    b.Navigation("ClassRoom");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Score", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Student", "Student")
                        .WithMany("Subject_Scores")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityManagement.Entities.Models.Subject", "Subject")
                        .WithMany("Subject_Score")
                        .HasForeignKey("IdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Student", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Student", "Student")
                        .WithMany("Subject_Students")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityManagement.Entities.Models.Subject", "Subject")
                        .WithMany("Subject_Students")
                        .HasForeignKey("IdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.ClassRoom", b =>
                {
                    b.Navigation("Subject")
                        .IsRequired();
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Deparment", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Student", b =>
                {
                    b.Navigation("Subject_Scores");

                    b.Navigation("Subject_Students");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject", b =>
                {
                    b.Navigation("Subject_Score");

                    b.Navigation("Subject_Students");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
