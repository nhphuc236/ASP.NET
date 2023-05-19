﻿using System;
using System.Collections.Generic;

namespace QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;

public partial class MasLoaiDauTu
{
    public byte LoaiDauTuId { get; set; }

    public string TenLoaiDauTu { get; set; } = null!;

    public string? MoTa { get; set; }

    public string? IsDeleted { get; set; }

    public int? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? LastUpdUserId { get; set; }

    public DateTime? LastUpdDate { get; set; }
}
