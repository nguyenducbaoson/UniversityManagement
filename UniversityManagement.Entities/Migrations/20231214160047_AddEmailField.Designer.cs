﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityManagement.Entities.Data;

#nullable disable

namespace UniversityManagement.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231214160047_AddEmailField")]
    partial class AddEmailField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniversityManagement.Entities.Models.Class", b =>
                {
                    b.Property<Guid>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("YearOfAdmission")
                        .HasColumnType("datetime2");

                    b.HasKey("ClassId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Class", (string)null);

                    b.HasData(
                        new
                        {
                            ClassId = new Guid("3fdddd8a-76c9-456e-bf35-5211f599016f"),
                            Amount = 75,
                            ClassName = "Công Nghệ Thông Tin 1",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("9c6c42ef-7167-41ce-af61-46bd7a9d66da"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("1fc38461-29bb-4123-9af6-aec3945bb378"),
                            Amount = 70,
                            ClassName = "Công Nghệ Thông Tin 2",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("9d7f09aa-4d7c-4f13-b52e-050dd8e73967"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("b41f3593-f66b-4b24-b82e-9b4af5294f7b"),
                            Amount = 46,
                            ClassName = "Marketing 2",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("9d7f09aa-4d7c-4f13-b52e-050dd8e73967"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("627ca7ba-82de-442e-80fc-a99b59f28286"),
                            Amount = 49,
                            ClassName = "Cơ Khí 1",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("3c1f9665-f8f7-42e2-8c38-4ef4f02b4bcf"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("00ed687d-de80-424c-a87c-b3f03a922724"),
                            Amount = 70,
                            ClassName = "Công Nghệ Thông Tin 3",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("b2e8e638-aaba-4a91-afb1-56dede21f2e2"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("2215e3b8-44f2-439c-9c02-107a8fb769e2"),
                            Amount = 60,
                            ClassName = "Quản Trị Kinh Doanh 1",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("3c1f9665-f8f7-42e2-8c38-4ef4f02b4bcf"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("02a4a852-f9de-43b9-91bc-f52dad047562"),
                            Amount = 72,
                            ClassName = "Luật Kinh Tế 1",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("b2e8e638-aaba-4a91-afb1-56dede21f2e2"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClassId = new Guid("5e1edcf4-7a25-491c-be13-0f30e69f9d41"),
                            Amount = 75,
                            ClassName = "Cơ Khí 2",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("3c1f9665-f8f7-42e2-8c38-4ef4f02b4bcf"),
                            YearOfAdmission = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.ClassRoom", b =>
                {
                    b.Property<Guid>("ClassRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassRoomName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ClassRoomId");

                    b.ToTable("ClassRoom", (string)null);

                    b.HasData(
                        new
                        {
                            ClassRoomId = new Guid("34c65d1b-cc7a-4d94-8723-ab5cdcce98a7"),
                            ClassRoomName = "Room 303A7",
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department", (string)null);

                    b.HasData(
                        new
                        {
                            DepartmentId = new Guid("b2e8e638-aaba-4a91-afb1-56dede21f2e2"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Công Nghệ Thông Tin",
                            Description = "No"
                        },
                        new
                        {
                            DepartmentId = new Guid("3c1f9665-f8f7-42e2-8c38-4ef4f02b4bcf"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Luật Kinh Tế",
                            Description = "No"
                        },
                        new
                        {
                            DepartmentId = new Guid("fce4b0c8-9005-4701-adca-bebd946b2252"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Quản Trị Kinh Doanh",
                            Description = "No"
                        },
                        new
                        {
                            DepartmentId = new Guid("9d7f09aa-4d7c-4f13-b52e-050dd8e73967"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Marketing",
                            Description = "No"
                        },
                        new
                        {
                            DepartmentId = new Guid("9c6c42ef-7167-41ce-af61-46bd7a9d66da"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentName = "Cơ Khí",
                            Description = "No"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("49dc19eb-df89-476d-8974-31b86aeb4344"),
                            Address = "Bắc Ninh",
                            ClassId = new Guid("5e1edcf4-7a25-491c-be13-0f30e69f9d41"),
                            DateOfBirth = new DateTime(2001, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 4,
                            StudentName = "Nguyễn Đức Bảo Sơn"
                        },
                        new
                        {
                            StudentId = new Guid("a9121c32-faa1-4394-803b-d064672a3a41"),
                            Address = "Hà Nội",
                            ClassId = new Guid("5e1edcf4-7a25-491c-be13-0f30e69f9d41"),
                            DateOfBirth = new DateTime(2001, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 4,
                            StudentName = "Nguyễn Quang Trung"
                        },
                        new
                        {
                            StudentId = new Guid("7c460a79-b7aa-4266-b0b2-825d9b4cf509"),
                            Address = "Bắc Giang",
                            ClassId = new Guid("627ca7ba-82de-442e-80fc-a99b59f28286"),
                            DateOfBirth = new DateTime(2001, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 4,
                            StudentName = "Nguyễn Mạnh Hiệp"
                        },
                        new
                        {
                            StudentId = new Guid("aba5aae7-739b-4484-8448-7a7edd8db5a1"),
                            Address = "Hà Nội",
                            ClassId = new Guid("b41f3593-f66b-4b24-b82e-9b4af5294f7b"),
                            DateOfBirth = new DateTime(2003, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 4,
                            StudentName = "Vũ Hoàng Minh"
                        },
                        new
                        {
                            StudentId = new Guid("e9211e39-c43c-4c42-a2ad-6bb41ac928e5"),
                            Address = "Hải Dương",
                            ClassId = new Guid("627ca7ba-82de-442e-80fc-a99b59f28286"),
                            DateOfBirth = new DateTime(1999, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 3,
                            StudentName = "Đoàn Duy Anh"
                        },
                        new
                        {
                            StudentId = new Guid("f67db176-22d1-4420-b683-8ab761a46948"),
                            Address = "Hà Nội",
                            ClassId = new Guid("627ca7ba-82de-442e-80fc-a99b59f28286"),
                            DateOfBirth = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 4,
                            StudentName = "Phan Tiến Anh"
                        },
                        new
                        {
                            StudentId = new Guid("31923cf0-edb4-49c7-ab24-a06aa8844095"),
                            Address = "Hà Nội",
                            ClassId = new Guid("b41f3593-f66b-4b24-b82e-9b4af5294f7b"),
                            DateOfBirth = new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 3,
                            StudentName = "Ngô Ngọc Đức"
                        },
                        new
                        {
                            StudentId = new Guid("c471576f-eb74-4c3d-8071-f78e5954d959"),
                            Address = "Nam Định",
                            ClassId = new Guid("3fdddd8a-76c9-456e-bf35-5211f599016f"),
                            DateOfBirth = new DateTime(1998, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 4,
                            StudentName = "Nguyễn Thị Khánh"
                        },
                        new
                        {
                            StudentId = new Guid("8b1ebf96-8589-4954-875e-87e04c830a04"),
                            Address = "Thái Bình",
                            ClassId = new Guid("b41f3593-f66b-4b24-b82e-9b4af5294f7b"),
                            DateOfBirth = new DateTime(2001, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            Status = 3,
                            StudentName = "Lê Kiến Trúc"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subject", (string)null);

                    b.HasData(
                        new
                        {
                            SubjectId = new Guid("3ca5fd36-8f24-4b2d-9292-1ea2772a30d6"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Lập Trình Web",
                            TeacherId = new Guid("d9a47258-d809-4fa1-b241-59ac8c01a50d")
                        },
                        new
                        {
                            SubjectId = new Guid("a1e6eb19-c594-42a9-9d2b-1f751baffa73"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "An Ninh Mạng",
                            TeacherId = new Guid("016de7a6-40a2-45c6-80f7-786810f00d27")
                        },
                        new
                        {
                            SubjectId = new Guid("48c76b9b-f83e-44b4-a3ca-1687859e84f9"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Trí Tuệ Nhân Tạo",
                            TeacherId = new Guid("d9a47258-d809-4fa1-b241-59ac8c01a50d")
                        },
                        new
                        {
                            SubjectId = new Guid("5c54dc1b-c003-4408-a7b8-84336e8fc16c"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Lịch Sử Đảng",
                            TeacherId = new Guid("b65a41d6-c25c-4867-8b7f-a3f52a57bc26")
                        },
                        new
                        {
                            SubjectId = new Guid("5a139003-5612-4a46-9e80-bf13c8f0a9ed"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Đại Số Tuyến Tính",
                            TeacherId = new Guid("2f043c43-cfd6-4948-9a9d-78ec32df6a9c")
                        },
                        new
                        {
                            SubjectId = new Guid("463a34c9-6b74-4a41-8b07-8cc2c8c1e7bf"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Cơ Sở Dữ Liệu",
                            TeacherId = new Guid("8fa7e6e3-2eab-479c-865a-033694979b04")
                        },
                        new
                        {
                            SubjectId = new Guid("8a9c8ce1-9df1-48f7-aa6f-0d3ac1b9813b"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Xử Lý Ảnh",
                            TeacherId = new Guid("016de7a6-40a2-45c6-80f7-786810f00d27")
                        },
                        new
                        {
                            SubjectId = new Guid("7721a15a-b8e0-4fdc-a561-0b660da56c03"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            SubjectName = "Khai Phá Dữ Liệu",
                            TeacherId = new Guid("0250e0e8-2ee9-43dc-8e13-7a0a0fda5e2a")
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Classroom", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassRoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "ClassRoomId");

                    b.HasIndex("ClassRoomId");

                    b.ToTable("Subject_Classroom");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Student", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Mark")
                        .HasColumnType("real");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Subject_Student");

                    b.HasData(
                        new
                        {
                            SubjectId = new Guid("8a9c8ce1-9df1-48f7-aa6f-0d3ac1b9813b"),
                            StudentId = new Guid("31923cf0-edb4-49c7-ab24-a06aa8844095"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mark = 7f,
                            Status = 1
                        },
                        new
                        {
                            SubjectId = new Guid("48c76b9b-f83e-44b4-a3ca-1687859e84f9"),
                            StudentId = new Guid("8b1ebf96-8589-4954-875e-87e04c830a04"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            SubjectId = new Guid("3ca5fd36-8f24-4b2d-9292-1ea2772a30d6"),
                            StudentId = new Guid("aba5aae7-739b-4484-8448-7a7edd8db5a1"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            SubjectId = new Guid("463a34c9-6b74-4a41-8b07-8cc2c8c1e7bf"),
                            StudentId = new Guid("f67db176-22d1-4420-b683-8ab761a46948"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            SubjectId = new Guid("7721a15a-b8e0-4fdc-a561-0b660da56c03"),
                            StudentId = new Guid("49dc19eb-df89-476d-8974-31b86aeb4344"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Teacher", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher", (string)null);

                    b.HasData(
                        new
                        {
                            TeacherId = new Guid("d9a47258-d809-4fa1-b241-59ac8c01a50d"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            TeacherName = "Bùi Ngọc Dũng"
                        },
                        new
                        {
                            TeacherId = new Guid("0250e0e8-2ee9-43dc-8e13-7a0a0fda5e2a"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            TeacherName = "Nguyễn Kim Sao"
                        },
                        new
                        {
                            TeacherId = new Guid("2f043c43-cfd6-4948-9a9d-78ec32df6a9c"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            TeacherName = "Nguyễn Thu Phương"
                        },
                        new
                        {
                            TeacherId = new Guid("016de7a6-40a2-45c6-80f7-786810f00d27"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            TeacherName = "Thiều Trần Cường"
                        },
                        new
                        {
                            TeacherId = new Guid("b65a41d6-c25c-4867-8b7f-a3f52a57bc26"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            TeacherName = "Đào Như Quỳnh"
                        },
                        new
                        {
                            TeacherId = new Guid("8fa7e6e3-2eab-479c-865a-033694979b04"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            TeacherName = "Nguyễn Gia Quý"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("16cf8c42-8e65-4772-9862-84c84efc10b1"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            FullName = "Nguyễn Đức Bảo Sơn",
                            Password = "Admin",
                            Role = "Admin",
                            UserName = "Admin"
                        },
                        new
                        {
                            UserId = new Guid("8791be24-35e1-4e8c-aee9-2e0e9c706609"),
                            DateOfCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "No",
                            FullName = "Bùi Linh Giang",
                            Password = "Giang",
                            Role = "User",
                            UserName = "Giang"
                        });
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Class", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Department", "Department")
                        .WithMany("Classes")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.RefreshToken", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Student", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Classroom", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.ClassRoom", "ClassRoom")
                        .WithMany("Subject_Classrooms")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityManagement.Entities.Models.Subject", "Subject")
                        .WithMany("Subject_Classroom")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject_Student", b =>
                {
                    b.HasOne("UniversityManagement.Entities.Models.Student", "Student")
                        .WithMany("Subject_Students")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityManagement.Entities.Models.Subject", "Subject")
                        .WithMany("Subject_Student")
                        .HasForeignKey("SubjectId")
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
                    b.Navigation("Subject_Classrooms");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Department", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Student", b =>
                {
                    b.Navigation("Subject_Students");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Subject", b =>
                {
                    b.Navigation("Subject_Classroom");

                    b.Navigation("Subject_Student");
                });

            modelBuilder.Entity("UniversityManagement.Entities.Models.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
