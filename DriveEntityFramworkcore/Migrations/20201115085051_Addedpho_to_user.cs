using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DriveEntityFramworkcore.Migrations
{
    public partial class Addedpho_to_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                schema: "Drive",
                table: "tblUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                schema: "Drive",
                table: "tblUsers");
        }
    }
}
