using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;
using QuanLyDuAnDauTu.Ser.Infrastructure;
using System.Reflection.Metadata.Ecma335;

namespace QuanLyDuAnDauTu.Ser.Services
{
    public interface IDanhMucService
    {
        public List<MasTinhThanh> GetAllTinhThanh();
        public List<MasQuanHuyen> GetQuanHuyenByTinhThanhId(int id);
        public List<MasPhuongXa> GetPhuongXaByQuanHuyenId(int id);
        public List<MasDonVi> GetAllDonViDauTu();
        public List<MasNguonVon> GetAllNguonVon();
        public List<MasHinhThucQldum> GetAllHinhThucQuanLyDuAn();
        public List<MasNhomDuAn> GetAllNhomDuAn();
        public List<MasLoaiDauTu> GetAllLoaiDauTu();
        public List<MasTinhChatCntt> GetAllTinhChatCntt();
        public List<MasPhanNhomCntt> GetAllPhanNhomCntt();
        public MasDonVi? GetDonViById(int id);
        public MasHinhThucQldum? GetHinhThucQldaById(int id);
        public MasLoaiDauTu? GetLoaiDauTuById(int id);
        public MasNguonVon? GetNguonVonById(int id);
        public MasNhomDuAn? GetNhomDuAnById(int id);
        public MasPhanNhomCntt? GetPhanNhomCnttById(int id);
        public MasTinhChatCntt? GetTinhChatCnttById(int id);

    }
    public class DanhMucService : IDanhMucService
    {
        private readonly ApplicationDbContext _context;

        public DanhMucService (ApplicationDbContext context)
        {
            _context = context;
        }

        public MasDonVi? GetDonViById(int id)
        {
            var result = _context.MasDonVis.Where(x => x.DonViId == id).FirstOrDefault();

            return result;
        }

        public MasHinhThucQldum? GetHinhThucQldaById(int id)
        {
            var result = _context.MasHinhThucQlda.Where(x => x.HinhThucQldaId == id).FirstOrDefault();

            return result;
        }

        public MasLoaiDauTu? GetLoaiDauTuById(int id)
        {
            var result = _context.MasLoaiDauTus.Where(x => x.LoaiDauTuId == id).FirstOrDefault();

            return result;
        }

        public MasNguonVon? GetNguonVonById(int id)
        {
            var result = _context.MasNguonVons.Where(x => x.NguonVonId == id).FirstOrDefault();

            return result;
        }

        public MasNhomDuAn? GetNhomDuAnById(int id)
        {
            var result = _context.MasNhomDuAns.Where(x => x.NhomDuAnId == id).FirstOrDefault();

            return result;
        }

        public MasPhanNhomCntt? GetPhanNhomCnttById(int id)
        {
            var result = _context.MasPhanNhomCntts.Where(x => x.PhanNhomCnttId == id).FirstOrDefault();

            return result;
        }

        public MasTinhChatCntt? GetTinhChatCnttById(int id)
        {
            var result = _context.MasTinhChatCntts.Where(x => x.TinhChatId == id).FirstOrDefault();

            return result;
        }

        public List<MasDonVi> GetAllDonViDauTu()
        {
            var result = _context.MasDonVis.ToList();

            return result;
        }

        public List<MasHinhThucQldum> GetAllHinhThucQuanLyDuAn()
        {
            var result = _context.MasHinhThucQlda.ToList();

            return result;
        }

        public List<MasLoaiDauTu> GetAllLoaiDauTu()
        {
            var result = _context.MasLoaiDauTus.ToList();

            return result;
        }

        public List<MasNguonVon> GetAllNguonVon()
        {
            var result = _context.MasNguonVons.ToList();

            return result;
        }

        public List<MasNhomDuAn> GetAllNhomDuAn()
        {
            var result = _context.MasNhomDuAns.ToList();

            return result;
        }

        public List<MasPhanNhomCntt> GetAllPhanNhomCntt()
        {
            var result = _context.MasPhanNhomCntts.ToList();

            return result;
        }

        public List<MasTinhChatCntt> GetAllTinhChatCntt()
        {
            var result = _context.MasTinhChatCntts.ToList();

            return result;
        }

        public List<MasTinhThanh> GetAllTinhThanh()
        {
            var result = _context.MasTinhThanhs.ToList();

            return result;
        }

        public List<MasPhuongXa> GetPhuongXaByQuanHuyenId(int id)
        {
            var result = _context.MasPhuongXas.Where(x => x.QuanHuyenId == id).ToList();

            return result;
        }

        public List<MasQuanHuyen> GetQuanHuyenByTinhThanhId(int id)
        {
            var result = _context.MasQuanHuyens.Where(x=>x.TinhThanhId == id).ToList();

            return result;
        }
    }
}
