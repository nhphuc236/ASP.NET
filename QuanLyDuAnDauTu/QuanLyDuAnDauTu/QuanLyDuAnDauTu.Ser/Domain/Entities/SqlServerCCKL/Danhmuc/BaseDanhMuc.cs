namespace QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc
{
    public abstract class BaseDanhMuc
    {
        public int Id { get ; set; }
        public string? Name { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }    
    }
}
