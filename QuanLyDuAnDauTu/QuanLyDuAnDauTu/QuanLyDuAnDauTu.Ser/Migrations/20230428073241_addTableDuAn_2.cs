using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class addTableDuAn_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VanBanPhapLy",
                table: "DU_AN");

            migrationBuilder.AlterColumn<string>(
                name: "TenDuAn",
                table: "DU_AN",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Mas_PhuongXa",
                columns: table => new
                {
                    PhuongXa_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhuongXa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenPhuongXa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    QuanHuyen_ID = table.Column<int>(type: "int", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsDeleted = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CreatedUser_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdUser_ID = table.Column<int>(type: "int", nullable: true),
                    LastUpdDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Mas_QuanHuyen",
                columns: table => new
                {
                    QuanHuyen_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaQuanHuyen = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenQuanHuyen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TinhThanh_ID = table.Column<byte>(type: "tinyint", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsDeleted = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CreatedUser_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdUser_ID = table.Column<int>(type: "int", nullable: true),
                    LastUpdDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Mas_TinhThanh",
                columns: table => new
                {
                    TinhThanh_ID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTinhThanh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenTinhThanh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsDeleted = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CreatedUser_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdUser_ID = table.Column<int>(type: "int", nullable: true),
                    LastUpdDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mas_PhuongXa");

            migrationBuilder.DropTable(
                name: "Mas_QuanHuyen");

            migrationBuilder.DropTable(
                name: "Mas_TinhThanh");

            migrationBuilder.AlterColumn<string>(
                name: "TenDuAn",
                table: "DU_AN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "VanBanPhapLy",
                table: "DU_AN",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
