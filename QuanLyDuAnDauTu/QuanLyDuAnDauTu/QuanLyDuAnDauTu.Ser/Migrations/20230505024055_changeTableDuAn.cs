using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class changeTableDuAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuyTrinhQuanLyDauTuID",
                table: "DU_AN",
                newName: "PhanNhomCNTTID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhanNhomCNTTID",
                table: "DU_AN",
                newName: "QuyTrinhQuanLyDauTuID");
        }
    }
}
