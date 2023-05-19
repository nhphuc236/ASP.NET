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
    [Migration("20230515072647_changeTableDuAn_9")]
    partial class changeTableDuAn_9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasDonVi", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<int>("DonViId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DonVi_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonViId"));

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MaDonVi")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("TenDonVi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.ToTable("Mas_DonVi", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasHinhThucQldum", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<short>("HinhThucQldaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("HinhThucQLDA_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("HinhThucQldaId"));

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("TenHinhThucQlda")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("TenHinhThucQLDA");

                    b.ToTable("Mas_HinhThucQLDA", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasLoaiDauTu", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<byte>("LoaiDauTuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("LoaiDauTu_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("LoaiDauTuId"));

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("TenLoaiDauTu")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.ToTable("Mas_LoaiDauTu", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasNguonVon", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<short>("NguonVonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("NguonVon_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("NguonVonId"));

                    b.Property<string>("TenNguonVon")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.ToTable("Mas_NguonVon", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasNhomDuAn", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<byte>("NhomDuAnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("NhomDuAn_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("NhomDuAnId"));

                    b.Property<string>("TenNhomDuAn")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.ToTable("Mas_NhomDuAn", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasPhanNhomCntt", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<byte>("PhanNhomCnttId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("PhanNhomCNTT_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("PhanNhomCnttId"));

                    b.Property<string>("TenPhanNhomCntt")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("TenPhanNhomCNTT");

                    b.ToTable("Mas_PhanNhomCNTT", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasPhuongXa", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MaPhuongXa")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("PhuongXaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PhuongXa_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhuongXaId"));

                    b.Property<int?>("QuanHuyenId")
                        .HasColumnType("int")
                        .HasColumnName("QuanHuyen_ID");

                    b.Property<string>("TenPhuongXa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.ToTable("Mas_PhuongXa", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasQuanHuyen", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MaQuanHuyen")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("QuanHuyenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("QuanHuyen_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuanHuyenId"));

                    b.Property<string>("TenQuanHuyen")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte?>("TinhThanhId")
                        .HasColumnType("tinyint")
                        .HasColumnName("TinhThanh_ID");

                    b.ToTable("Mas_QuanHuyen", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasTinhChatCntt", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("TenTinhChat")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("TinhChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("TinhChat_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("TinhChatId"));

                    b.ToTable("Mas_TinhChatCNTT", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasTinhThanh", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MaTinhThanh")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("TenTinhThanh")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("TinhThanhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("TinhThanh_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("TinhThanhId"));

                    b.ToTable("Mas_TinhThanh", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasTrangThai", b =>
                {
                    b.Property<short>("TrangThaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("TrangThai_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("TrangThaiId"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedUser_ID");

                    b.Property<string>("IsDeleted")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<int?>("LastUpdUserId")
                        .HasColumnType("int")
                        .HasColumnName("LastUpdUser_ID");

                    b.Property<string>("MoTa")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TenTrangThai")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TrangThaiId");

                    b.ToTable("Mas_TrangThai", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan.DuAn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("ChiPhiDuPhong")
                        .HasColumnType("bigint");

                    b.Property<long?>("ChiPhiKhac")
                        .HasColumnType("bigint");

                    b.Property<long?>("ChiPhiQuanLyDuAn")
                        .HasColumnType("bigint");

                    b.Property<long?>("ChiPhiThietBi")
                        .HasColumnType("bigint");

                    b.Property<long?>("ChiPhiTuVan")
                        .HasColumnType("bigint");

                    b.Property<long?>("ChiPhiXayLap")
                        .HasColumnType("bigint");

                    b.Property<int>("ChuDauTuID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUser_ID")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HinhThucQuanLyDuAnID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdUser_ID")
                        .HasColumnType("int");

                    b.Property<string>("MaDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MucTieuDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NguonVonID")
                        .HasColumnType("int");

                    b.Property<string>("NoiDungVaQuyMo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhanLoaiDuAnID")
                        .HasColumnType("int");

                    b.Property<int?>("PhanNhomCNTTID")
                        .HasColumnType("int");

                    b.Property<int?>("PhanNhomDuAnID")
                        .HasColumnType("int");

                    b.Property<int>("PhuongXaID")
                        .HasColumnType("int");

                    b.Property<int>("QuanHuyenID")
                        .HasColumnType("int");

                    b.Property<string>("SoDuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TenDuAn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThucHienDenNgay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThucHienTuNgay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TinhChatDuAnID")
                        .HasColumnType("int");

                    b.Property<int>("TinhThanhID")
                        .HasColumnType("int");

                    b.Property<string>("TongMucDauTu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("TrangThaiID")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("TrangThaiID");

                    b.HasIndex(new[] { "Id" }, "IX_DUAN_DuAnId");

                    b.ToTable("DU_AN", (string)null);
                });

            modelBuilder.Entity("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan.DuAn", b =>
                {
                    b.HasOne("QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc.MasTrangThai", "TrangThai")
                        .WithMany()
                        .HasForeignKey("TrangThaiID");

                    b.Navigation("TrangThai");
                });
#pragma warning restore 612, 618
        }
    }
}