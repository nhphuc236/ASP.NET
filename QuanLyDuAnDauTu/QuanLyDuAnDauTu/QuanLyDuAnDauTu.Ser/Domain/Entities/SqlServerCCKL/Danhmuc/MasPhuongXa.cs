using System;
using System.Collections.Generic;

namespace QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;

public partial class MasPhuongXa
{
    public int PhuongXaId { get; set; }

    public string MaPhuongXa { get; set; } = null!;

    public string TenPhuongXa { get; set; } = null!;

    public int? QuanHuyenId { get; set; }

    public string? MoTa { get; set; }

    public string? IsDeleted { get; set; }

    public int? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? LastUpdUserId { get; set; }

    public DateTime? LastUpdDate { get; set; }
}
