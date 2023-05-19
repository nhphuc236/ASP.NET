using System;
using System.Collections.Generic;

namespace QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;

public partial class MasQuanHuyen
{
    public int QuanHuyenId { get; set; }

    public string MaQuanHuyen { get; set; } = null!;

    public string? TenQuanHuyen { get; set; }

    public byte? TinhThanhId { get; set; }

    public string? MoTa { get; set; }

    public string? IsDeleted { get; set; }

    public int? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? LastUpdUserId { get; set; }

    public DateTime? LastUpdDate { get; set; }
}
