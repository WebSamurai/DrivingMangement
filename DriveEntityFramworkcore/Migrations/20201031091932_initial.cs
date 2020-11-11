using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DriveEntityFramworkcore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblUsers",
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
                    Surname = table.Column<string>(maxLength: 64, nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    IsEmailConfirmed = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false),
                    AuthenticationSource = table.Column<string>(maxLength: 64, nullable: true),
                    EmailConfirmationCode = table.Column<string>(maxLength: 328, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblVehicles",
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
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblBatches",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    BatchTime = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    SchoolId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBatches_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployees",
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
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEnquiries",
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
                    SchoolId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEnquiries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEnquiries_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStudents",
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
                        principalTable: "tblBatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblStudents_tblSchools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "tblSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBatches_SchoolId",
                table: "tblBatches",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployees_SchoolId",
                table: "tblEmployees",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEnquiries_SchoolId",
                table: "tblEnquiries",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSchools_OwnerId",
                table: "tblSchools",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_BatchId",
                table: "tblStudents",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_SchoolId",
                table: "tblStudents",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployees");

            migrationBuilder.DropTable(
                name: "tblEnquiries");

            migrationBuilder.DropTable(
                name: "tblStudents");

            migrationBuilder.DropTable(
                name: "tblVehicles");

            migrationBuilder.DropTable(
                name: "tblBatches");

            migrationBuilder.DropTable(
                name: "tblSchools");

            migrationBuilder.DropTable(
                name: "tblUsers");
        }
    }
}
