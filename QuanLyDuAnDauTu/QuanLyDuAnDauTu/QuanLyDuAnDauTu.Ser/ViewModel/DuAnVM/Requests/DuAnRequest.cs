using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;

namespace QuanLyDuAnDauTu.Ser.ViewModel.DuAnVM.Requests
{
    public class DuAnSearchRequest:PaginationRequest
    {
        public int? ChuDauTuID { get; set; }
        public string? TenDuAn { get; set; }
        public DateTime? ThucHienTuNgay { get; set; }
        public DateTime? ThucHienDenNgay { get; set; }
        public int? LoaiDuAnID { get; set; }
        public int? TrangThaiID { get; set; }
    }
    public class DuAnUpdateRequest
    {
        public Guid Id { get; set; }
        public string? MaDuAn { get; set; }
        public int ChuDauTuID { get; set; }
        public string TenDuAn { get; set; } = string.Empty;
        public string? MucTieuDuAn { get; set; } = string.Empty;
        public string? NoiDungVaQuyMo { get; set; } = string.Empty;
        public int TinhThanhID { get; set; }
        public int QuanHuyenID { get; set; }
        public int PhuongXaID { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string SoDuong { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string? DiaChi { get; set; } = string.Empty;
        public int NguonVonID { get; set; }
        public int HinhThucQuanLyDuAnID { get; set; }
        public DateTime? ThucHienTuNgay { get; set; }
        public DateTime? ThucHienDenNgay { get; set; }
        public int PhanNhomCNTTID { get; set; }
        public int PhanNhomDuAnID { get; set; }
        public int PhanLoaiDuAnID { get; set; }
        public int TinhChatDuAnID { get; set; }
        public string? TongMucDauTu { get; set; } = string.Empty;
        public long ChiPhiXayLap { get; set; }
        public long ChiPhiThietBi { get; set; }
        public long ChiPhiQuanLyDuAn { get; set; }
        public long ChiPhiTuVan { get; set; }
        public long ChiPhiKhac { get; set; }
        public long ChiPhiDuPhong { get; set; }
        public int? LastUpdUser_ID { get; set; } = 112233;
        public DateTime? LastUpdDate { get; set; } = DateTime.Now;
    }
    public class DuAnUpdateTrangThaiRequest
    {
        public Guid Id { get; set; }
        public int TrangThaiID { get; set; }
    }
}
