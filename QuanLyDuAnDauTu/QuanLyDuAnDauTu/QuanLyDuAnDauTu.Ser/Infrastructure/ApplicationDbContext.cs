

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan;
using QuanLyDuAnDauTu.Ser.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QuanLyDuAnDauTu.Ser.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(){}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}


        // Tao bang
        public DbSet<DuAn> DuAns { get; set; }

        public virtual DbSet<MasPhuongXa> MasPhuongXas { get; set; }

        public virtual DbSet<MasQuanHuyen> MasQuanHuyens { get; set; }

        public virtual DbSet<MasTinhThanh> MasTinhThanhs { get; set; }

        public virtual DbSet<MasDonVi> MasDonVis { get; set; }

        public virtual DbSet<MasHinhThucQldum> MasHinhThucQlda { get; set; }

        public virtual DbSet<MasLoaiDauTu> MasLoaiDauTus { get; set; }

        public virtual DbSet<MasNguonVon> MasNguonVons { get; set; }

        public virtual DbSet<MasNhomDuAn> MasNhomDuAns { get; set; }

        public virtual DbSet<MasPhanNhomCntt> MasPhanNhomCntts { get; set; }

        public virtual DbSet<MasTinhChatCntt> MasTinhChatCntts { get; set; }
        public virtual DbSet<MasTrangThai> MasTrangThais { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .LogTo(Console.WriteLine)
                    .UseSqlServer("Data Source=DESKTOP-IT54C15\\SQLEXPRESS;Initial Catalog=VI_QLDA;Integrated Security=True; TrustServerCertificate=True;", x => x.UseNetTopologySuite());
            }
        }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DuAn>(entity =>
            {
                entity.ToTable("DU_AN");

                entity.HasIndex(e => e.Id, "IX_DUAN_DuAnId");

                //entity.HasOne(d => d.Chusohuu)
                //    .WithMany(p => p.ChusohuuBuocs)
                //    .HasForeignKey(d => d.ChuSoHuuId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("FK_BUOC_CHUSOHUU");

                entity
                    .HasOne(d => d.TrangThai)
                    .WithMany()
                    .HasForeignKey(d => d.TrangThaiID);
            });
            // Tao bang trong SQL

            // tao migration
            //dotnet ef migrations add addTableDuAn - c ApplicationDbContext - o "Migrations"

            //xem ds migra
            //dotnet ef migrations list

            // Update SQL
            //dotnet ef database update

            modelBuilder.Entity<MasPhuongXa>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_PhuongXa");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MaPhuongXa).HasMaxLength(5);
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.PhuongXaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PhuongXa_ID");
                entity.Property(e => e.QuanHuyenId).HasColumnName("QuanHuyen_ID");
                entity.Property(e => e.TenPhuongXa).HasMaxLength(200);
            });

            modelBuilder.Entity<MasQuanHuyen>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_QuanHuyen");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MaQuanHuyen).HasMaxLength(5);
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.QuanHuyenId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("QuanHuyen_ID");
                entity.Property(e => e.TenQuanHuyen).HasMaxLength(200);
                entity.Property(e => e.TinhThanhId).HasColumnName("TinhThanh_ID");
            });

            modelBuilder.Entity<MasTinhThanh>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_TinhThanh");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MaTinhThanh).HasMaxLength(5);
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.TenTinhThanh).HasMaxLength(200);
                entity.Property(e => e.TinhThanhId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TinhThanh_ID");
            });

            modelBuilder.Entity<MasDonVi>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_DonVi");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.DonViId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DonVi_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MaDonVi).HasMaxLength(10);
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.TenDonVi).HasMaxLength(200);
            });

            modelBuilder.Entity<MasHinhThucQldum>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_HinhThucQLDA");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.HinhThucQldaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HinhThucQLDA_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.TenHinhThucQlda)
                    .HasMaxLength(200)
                    .HasColumnName("TenHinhThucQLDA");
            });

            modelBuilder.Entity<MasLoaiDauTu>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_LoaiDauTu");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.LoaiDauTuId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LoaiDauTu_ID");
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.TenLoaiDauTu).HasMaxLength(200);
            });

            modelBuilder.Entity<MasNguonVon>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_NguonVon");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.NguonVonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NguonVon_ID");
                entity.Property(e => e.TenNguonVon).HasMaxLength(200);
            });

            modelBuilder.Entity<MasNhomDuAn>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_NhomDuAn");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.NhomDuAnId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NhomDuAn_ID");
                entity.Property(e => e.TenNhomDuAn).HasMaxLength(200);
            });

            modelBuilder.Entity<MasPhanNhomCntt>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_PhanNhomCNTT");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.PhanNhomCnttId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PhanNhomCNTT_ID");
                entity.Property(e => e.TenPhanNhomCntt)
                    .HasMaxLength(200)
                    .HasColumnName("TenPhanNhomCNTT");
            });

            modelBuilder.Entity<MasTinhChatCntt>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Mas_TinhChatCNTT");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MoTa).HasMaxLength(2000);
                entity.Property(e => e.TenTinhChat).HasMaxLength(200);
                entity.Property(e => e.TinhChatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TinhChat_ID");
            });

            modelBuilder.Entity<MasTrangThai>(entity =>
            {
                entity.ToTable("Mas_TrangThai");

                entity.HasKey(e => e.TrangThaiId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUser_ID");
                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastUpdUserId).HasColumnName("LastUpdUser_ID");
                entity.Property(e => e.MoTa).HasMaxLength(1000);
                entity.Property(e => e.TenTrangThai).HasMaxLength(200);
                entity.Property(e => e.TrangThaiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TrangThai_ID");
            });

        }

    }
}
