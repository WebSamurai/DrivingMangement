using Microsoft.EntityFrameworkCore.Migrations;

namespace DriveEntityFramworkcore.Migrations
{
    public partial class Addchangeduserfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Drive",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                schema: "Drive",
                table: "tblUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Drive",
                table: "tblUsers",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Drive",
                table: "tblUsers",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Drive",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Drive",
                table: "tblUsers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Drive",
                table: "tblUsers",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                schema: "Drive",
                table: "tblUsers",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }
    }
}
