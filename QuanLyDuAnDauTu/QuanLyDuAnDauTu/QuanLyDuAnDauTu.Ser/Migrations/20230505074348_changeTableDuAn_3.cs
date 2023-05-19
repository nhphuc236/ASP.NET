using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class changeTableDuAn_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DU_AN",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "DU_AN",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DU_AN");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DU_AN");
        }
    }
}
