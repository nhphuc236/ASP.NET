﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyDuAnDauTu.Ser.Infrastructure;

#nullable disable

namespace QuanLyDuAnDauTu.Ser.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230424033742_addTableDuAn")]
    partial class addTableDuAn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan.DuAn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ChiPhiDuPhong")
                        .HasColumnType("bigint");

                    b.Property<long>("ChiPhiKhac")
                        .HasColumnType("bigint");

                    b.Property<long>("ChiPhiQuanLyDuAn")
                        .HasColumnType("bigint");

                    b.Property<long>("ChiPhiThietBi")
                        .HasColumnType("bigint");

                    b.Property<long>("ChiPhiTuVan")
                        .HasColumnType("bigint");

                    b.Property<long>("ChiPhiXayLap")
                        .HasColumnType("bigint");

                    b.Property<int>("ChuDauTuID")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HinhThucQuanLyDuAnID")
                        .HasColumnType("int");

                    b.Property<string>("MaDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MucTieuDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NguonVonID")
                        .HasColumnType("int");

                    b.Property<string>("NoiDungVaQuyMo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhanLoaiDuAnID")
                        .HasColumnType("int");

                    b.Property<int>("PhanNhomDuAnID")
                        .HasColumnType("int");

                    b.Property<int>("PhuongXaID")
                        .HasColumnType("int");

                    b.Property<int>("QuanHuyenID")
                        .HasColumnType("int");

                    b.Property<int>("QuyTrinhQuanLyDauTuID")
                        .HasColumnType("int");

                    b.Property<string>("TenDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ThucHienDenNgay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ThucHienTuNgay")
                        .HasColumnType("datetime2");

                    b.Property<int>("TinhChatDuAnID")
                        .HasColumnType("int");

                    b.Property<int>("TinhThanhID")
                        .HasColumnType("int");

                    b.Property<string>("TongMucDauTu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VanBanPhapLy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IX_DUAN_DuAnId");

                    b.ToTable("DU_AN", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
