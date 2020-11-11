﻿// <auto-generated />
using System;
using DriveEntityFramworkcore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DriveEntityFramworkcore.Migrations
{
    [DbContext(typeof(DriveDbContext))]
    partial class DriveDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Drive")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DriveEntities.Entities.Batch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BatchTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("tblBatches");
                });

            modelBuilder.Entity("DriveEntities.Entities.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(512)")
                        .HasMaxLength(512);

                    b.Property<string>("AlternateNo")
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<byte>("JobType")
                        .HasColumnType("smallint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("MidleName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("bytea");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("tblEmployees");
                });

            modelBuilder.Entity("DriveEntities.Entities.Enquiry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("AlternateNo")
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<bool>("CloseEnquiry")
                        .HasColumnType("boolean");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("EnquiryStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("FollowupDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("MidleName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("bytea");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.Property<bool>("isWatsApp")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("tblEnquiries");
                });

            modelBuilder.Entity("DriveEntities.Entities.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(512)")
                        .HasMaxLength(512);

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("LogoImage")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("tagLine")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("tblSchools");
                });

            modelBuilder.Entity("DriveEntities.Entities.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(512)")
                        .HasMaxLength(512);

                    b.Property<string>("AlternateNo")
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CourseEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CourseStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<byte>("Gender")
                        .HasColumnType("smallint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("MidleName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("bytea");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.Property<bool>("isWatsApp")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("SchoolId");

                    b.ToTable("tblStudents");
                });

            modelBuilder.Entity("DriveEntities.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("AuthenticationSource")
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("EmailConfirmationCode")
                        .HasColumnType("character varying(328)")
                        .HasMaxLength(328);

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsTwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PasswordResetCode")
                        .HasColumnType("character varying(328)")
                        .HasMaxLength(328);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("tblUsers");
                });

            modelBuilder.Entity("DriveEntities.Entities.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("character varying(16)")
                        .HasMaxLength(16);

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("tblVehicles");
                });

            modelBuilder.Entity("DriveEntities.Entities.Batch", b =>
                {
                    b.HasOne("DriveEntities.Entities.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveEntities.Entities.Employee", b =>
                {
                    b.HasOne("DriveEntities.Entities.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveEntities.Entities.Enquiry", b =>
                {
                    b.HasOne("DriveEntities.Entities.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveEntities.Entities.School", b =>
                {
                    b.HasOne("DriveEntities.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveEntities.Entities.Student", b =>
                {
                    b.HasOne("DriveEntities.Entities.Batch", "Batch")
                        .WithMany("Students")
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DriveEntities.Entities.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
