using System;
using System.Collections.Generic;

namespace QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;

public partial class MasHinhThucQldum
{
    public short HinhThucQldaId { get; set; }

    public string TenHinhThucQlda { get; set; } = null!;

    public string? MoTa { get; set; }

    public string? IsDeleted { get; set; }

    public int? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? LastUpdUserId { get; set; }

    public DateTime? LastUpdDate { get; set; }
}
