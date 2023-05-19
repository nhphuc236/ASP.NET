using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    /// <inheritdoc />
    public partial class changeTableDuAn_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DU_AN",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUser_ID",
                table: "DU_AN",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdDate",
                table: "DU_AN",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdUser_ID",
                table: "DU_AN",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DU_AN");

            migrationBuilder.DropColumn(
                name: "CreatedUser_ID",
                table: "DU_AN");

            migrationBuilder.DropColumn(
                name: "LastUpdDate",
                table: "DU_AN");

            migrationBuilder.DropColumn(
                name: "LastUpdUser_ID",
                table: "DU_AN");
        }
    }
}
