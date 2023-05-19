using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class addTableDuAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DU_AN",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDuAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuDauTuID = table.Column<int>(type: "int", nullable: false),
                    TenDuAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieuDuAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDungVaQuyMo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhThanhID = table.Column<int>(type: "int", nullable: false),
                    QuanHuyenID = table.Column<int>(type: "int", nullable: false),
                    PhuongXaID = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonVonID = table.Column<int>(type: "int", nullable: false),
                    HinhThucQuanLyDuAnID = table.Column<int>(type: "int", nullable: false),
                    ThucHienTuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThucHienDenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuyTrinhQuanLyDauTuID = table.Column<int>(type: "int", nullable: false),
                    PhanNhomDuAnID = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiDuAnID = table.Column<int>(type: "int", nullable: false),
                    TinhChatDuAnID = table.Column<int>(type: "int", nullable: false),
                    TongMucDauTu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiPhiXayLap = table.Column<long>(type: "bigint", nullable: false),
                    ChiPhiThietBi = table.Column<long>(type: "bigint", nullable: false),
                    ChiPhiQuanLyDuAn = table.Column<long>(type: "bigint", nullable: false),
                    ChiPhiTuVan = table.Column<long>(type: "bigint", nullable: false),
                    ChiPhiKhac = table.Column<long>(type: "bigint", nullable: false),
                    ChiPhiDuPhong = table.Column<long>(type: "bigint", nullable: false),
                    VanBanPhapLy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DU_AN", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DUAN_DuAnId",
                table: "DU_AN",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DU_AN");
        }
    }
}
