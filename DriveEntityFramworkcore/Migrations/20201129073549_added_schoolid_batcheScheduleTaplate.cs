using Microsoft.EntityFrameworkCore.Migrations;

namespace DriveEntityFramworkcore.Migrations
{
    public partial class added_schoolid_batcheScheduleTaplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SchoolId",
                schema: "Drive",
                table: "tblBatchScheduleTemplate",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_tblBatchScheduleTemplate_SchoolId",
                schema: "Drive",
                table: "tblBatchScheduleTemplate",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBatchScheduleTemplate_tblSchools_SchoolId",
                schema: "Drive",
                table: "tblBatchScheduleTemplate",
                column: "SchoolId",
                principalSchema: "Drive",
                principalTable: "tblSchools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBatchScheduleTemplate_tblSchools_SchoolId",
                schema: "Drive",
                table: "tblBatchScheduleTemplate");

            migrationBuilder.DropIndex(
                name: "IX_tblBatchScheduleTemplate_SchoolId",
                schema: "Drive",
                table: "tblBatchScheduleTemplate");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                schema: "Drive",
                table: "tblBatchScheduleTemplate");
        }
    }
}
