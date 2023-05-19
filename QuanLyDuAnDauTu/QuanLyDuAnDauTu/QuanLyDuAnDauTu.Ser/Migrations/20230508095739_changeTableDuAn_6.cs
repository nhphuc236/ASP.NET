using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class changeTableDuAn_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "TrangThaiID",
                table: "DU_AN",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThaiID",
                table: "DU_AN");
        }
    }
}
