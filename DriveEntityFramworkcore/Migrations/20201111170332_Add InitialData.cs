using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace DriveEntityFramworkcore.Migrations
{
    public partial class AddInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          ///  migrationBuilder.Sql(File.ReadAllText(@"../scripts/InitialData.sql"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
