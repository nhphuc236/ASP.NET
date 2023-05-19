using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class changeTableDuAn_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Mas_TrangThai",
                table: "Mas_TrangThai",
                column: "TrangThai_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DU_AN_TrangThaiID",
                table: "DU_AN",
                column: "TrangThaiID");

            migrationBuilder.AddForeignKey(
                name: "FK_DU_AN_Mas_TrangThai_TrangThaiID",
                table: "DU_AN",
                column: "TrangThaiID",
                principalTable: "Mas_TrangThai",
                principalColumn: "TrangThai_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DU_AN_Mas_TrangThai_TrangThaiID",
                table: "DU_AN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mas_TrangThai",
                table: "Mas_TrangThai");

            migrationBuilder.DropIndex(
                name: "IX_DU_AN_TrangThaiID",
                table: "DU_AN");
        }
    }
}
