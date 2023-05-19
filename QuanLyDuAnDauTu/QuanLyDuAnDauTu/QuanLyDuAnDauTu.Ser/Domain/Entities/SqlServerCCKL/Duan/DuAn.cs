using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan
{
    public class DuAn
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? MaDuAn { get; set; }
        public int ChuDauTuID { get; set; }
        public string TenDuAn { get; set; } = string.Empty;
        public string? MucTieuDuAn { get; set; } = string.Empty;
        public string NoiDungVaQuyMo { get; set; } = string.Empty;
        public int TinhThanhID { get; set; }
        public int QuanHuyenID { get; set; }
        public int PhuongXaID { get; set; }

        public string SoDuong { get; set; }
        public string? DiaChi { get; set; } = string.Empty;
        public int? NguonVonID { get; set; }
        public int? HinhThucQuanLyDuAnID { get; set; }
        public DateTime ThucHienTuNgay { get; set; }
        public DateTime ThucHienDenNgay { get; set; }
        public int? PhanNhomCNTTID { get; set; }
        public int? PhanNhomDuAnID { get; set; }
        public int? PhanLoaiDuAnID { get; set; }
        public int? TinhChatDuAnID { get; set; }
        public string TongMucDauTu { get; set; } = string.Empty;
        public long? ChiPhiXayLap { get; set; }
        public long? ChiPhiThietBi { get; set; }
        public long? ChiPhiQuanLyDuAn  { get; set; }
        public long? ChiPhiTuVan { get; set; }
        public long? ChiPhiKhac { get; set; }
        public long? ChiPhiDuPhong { get; set; }
        public short? TrangThaiID { get; set; }
   
        public virtual MasTrangThai? TrangThai { get; set; }
        public int? CreatedUser_ID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdUser_ID { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public bool? Status { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

