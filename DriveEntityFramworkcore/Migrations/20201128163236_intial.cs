﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DriveEntityFramworkcore.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Drive");

            migrationBuilder.CreateTable(
                name: "tblBatchScheduleTemplate",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    NumberOfPracticalSession = table.Column<int>(nullable: false),
                    NumberOfTheorySession = table.Column<int>(nullable: false),
                    TheoryTime = table.Column<DateTime>(nullable: false),
                    PracticalTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBatchScheduleTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsTwoFactorEnabled = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(maxLength: 128, nullable: true),
                    IsPhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 32, nullable: true),
                    IsLockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    PasswordResetCode = table.Column<string>(maxLength: 328, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    LastName = table.Column<string>(maxLength: 64, nullable: false),
                    FirstName = table.Column<string>(maxLength: 64, nullable: false),
                    IsEmailConfirmed = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false),
                    AuthenticationSource = table.Column<string>(maxLength: 64, nullable: true),
                    EmailConfirmationCode = table.Column<string>(maxLength: 328, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblVehicles",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModelName = table.Column<string>(maxLength: 256, nullable: false),
                    Number = table.Column<string>(maxLength: 16, nullable: false),
                    Photo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSchools",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Address = table.Column<string>(maxLength: 512, nullable: false),
                    OwnerId = table.Column<long>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LogoImage = table.Column<byte[]>(nullable: true),
                    tagLine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSchools_tblUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Drive",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblBatches",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    BatchTime = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    SchoolId = table.Column<long>(nullable: false),
                    BatchScheduleTemplateId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBatches_tblBatchScheduleTemplate_BatchScheduleTemplateId",
                        column: x => x.BatchScheduleTemplateId,
                        principalSchema: "Drive",
                        principalTable: "tblBatchScheduleTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblBatches_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "Drive",
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployees",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(maxLength: 256, nullable: false),
                    MidleName = table.Column<string>(maxLength: 256, nullable: true),
                    LastName = table.Column<string>(maxLength: 256, nullable: false),
                    Address = table.Column<string>(maxLength: 512, nullable: false),
                    JobType = table.Column<byte>(nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 12, nullable: false),
                    AlternateNo = table.Column<string>(maxLength: 12, nullable: true),
                    ProfilePicture = table.Column<byte[]>(nullable: true),
                    SchoolId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployees_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "Drive",
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEnquiries",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(maxLength: 256, nullable: false),
                    MidleName = table.Column<string>(maxLength: 256, nullable: true),
                    LastName = table.Column<string>(maxLength: 256, nullable: false),
                    Address = table.Column<string>(maxLength: 256, nullable: false),
                    EnquiryStartDate = table.Column<DateTime>(nullable: false),
                    FollowupDate = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    MobileNo = table.Column<string>(nullable: false),
                    isWatsApp = table.Column<bool>(nullable: false),
                    AlternateNo = table.Column<string>(maxLength: 12, nullable: true),
                    ProfilePicture = table.Column<byte[]>(nullable: true),
                    CloseEnquiry = table.Column<bool>(nullable: false),
                    SchoolId = table.Column<long>(nullable: false),
                    Gender = table.Column<byte>(nullable: false),
                    PrefferdBatch = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEnquiries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEnquiries_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "Drive",
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStudents",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(maxLength: 256, nullable: false),
                    MidleName = table.Column<string>(maxLength: 256, nullable: true),
                    LastName = table.Column<string>(maxLength: 256, nullable: false),
                    Address = table.Column<string>(maxLength: 512, nullable: false),
                    CourseStartDate = table.Column<DateTime>(nullable: false),
                    CourseEndDate = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 12, nullable: false),
                    isWatsApp = table.Column<bool>(nullable: false),
                    AlternateNo = table.Column<string>(maxLength: 12, nullable: true),
                    ProfilePicture = table.Column<byte[]>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<byte>(nullable: false),
                    BatchId = table.Column<long>(nullable: false),
                    SchoolId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblStudents_tblBatches_BatchId",
                        column: x => x.BatchId,
                        principalSchema: "Drive",
                        principalTable: "tblBatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblStudents_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "Drive",
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStudentSchedule",
                schema: "Drive",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScheduleDate = table.Column<DateTime>(nullable: false),
                    ScheduleTime = table.Column<DateTime>(nullable: false),
                    IsAttended = table.Column<bool>(nullable: false),
                    Scheduletype = table.Column<byte>(nullable: false),
                    BatchScheduleTemplateId = table.Column<long>(nullable: false),
                    StudentId = table.Column<long>(nullable: false),
                    IsInstructorSignOff = table.Column<bool>(nullable: false),
                    InstructorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudentSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblStudentSchedule_tblBatchScheduleTemplate_BatchScheduleTe~",
                        column: x => x.BatchScheduleTemplateId,
                        principalSchema: "Drive",
                        principalTable: "tblBatchScheduleTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblStudentSchedule_tblStudents_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "Drive",
                        principalTable: "tblStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBatches_BatchScheduleTemplateId",
                schema: "Drive",
                table: "tblBatches",
                column: "BatchScheduleTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBatches_SchoolId",
                schema: "Drive",
                table: "tblBatches",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployees_SchoolId",
                schema: "Drive",
                table: "tblEmployees",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEnquiries_SchoolId",
                schema: "Drive",
                table: "tblEnquiries",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSchools_OwnerId",
                schema: "Drive",
                table: "tblSchools",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_BatchId",
                schema: "Drive",
                table: "tblStudents",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_SchoolId",
                schema: "Drive",
                table: "tblStudents",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudentSchedule_BatchScheduleTemplateId",
                schema: "Drive",
                table: "tblStudentSchedule",
                column: "BatchScheduleTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudentSchedule_StudentId",
                schema: "Drive",
                table: "tblStudentSchedule",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployees",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblEnquiries",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblStudentSchedule",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblVehicles",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblStudents",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblBatches",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblBatchScheduleTemplate",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblSchools",
                schema: "Drive");

            migrationBuilder.DropTable(
                name: "tblUsers",
                schema: "Drive");
        }
    }
}
