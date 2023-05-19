using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan;
using QuanLyDuAnDauTu.Ser.Infrastructure;
using QuanLyDuAnDauTu.Ser.ViewModel;
using QuanLyDuAnDauTu.Ser.ViewModel.DuAnVM.Requests;
using QuanLyDuAnDauTu.Ser.ViewModel.DuAnVM.Response;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static QuanLyDuAnDauTu.Ser.ViewModel.Enum;

namespace QuanLyDuAnDauTu.Ser.Services
{
    public interface IDuAnService
    {
        public DuAn? GetById(Guid id);
        public DuAn PostService(DuAn duAn);
        public List<DuAn> GetAllDuAn();
        public List<DuAn> GetDuAnBySearch(DuAnSearchRequest duAnRequest);
        public DuAn? SoftDeleteDuAnById(Guid id);
        public DuAn? UpdateDuAn(DuAnUpdateRequest duAn);
        public DuAn? UpdateTrangThaiDuAn(DuAnUpdateTrangThaiRequest duAn);
    }
    public class DuAnService : IDuAnService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public DuAnService (ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DuAn? SoftDeleteDuAnById(Guid id)
        {
            var result = _context.DuAns.Where(x => x.Id == id).FirstOrDefault();
            
            if (result != null)
            {
                result.IsDeleted = true;
                _context.DuAns.Update(result);
                _context.SaveChanges();
            }

            return result;
        }

        public List<DuAn> GetDuAnBySearch(DuAnSearchRequest duAnRequest)
        {
            var result = _context.DuAns.Where(x => x.IsDeleted == false).Include(_=>_.TrangThai).ToList();

            if (duAnRequest.ChuDauTuID != 0 && duAnRequest.ChuDauTuID != null)
            {
                result = result.Where(x => x.ChuDauTuID == duAnRequest.ChuDauTuID).ToList();
            }

            if (duAnRequest.TenDuAn != null)
            {
                result = result.Where(x => x.TenDuAn.Contains(duAnRequest.TenDuAn)).ToList();
            }

            if (duAnRequest.ThucHienTuNgay != null)
            {
                result = result.Where(x => x.ThucHienTuNgay >= duAnRequest.ThucHienTuNgay).ToList();

            }    

            if (duAnRequest.ThucHienDenNgay != null)
            {
                result = result.Where(x => x.ThucHienDenNgay <= duAnRequest.ThucHienDenNgay).ToList();
            }

            if (duAnRequest.LoaiDuAnID != null)
            {
                result = result.Where(x => x.PhanLoaiDuAnID == duAnRequest.LoaiDuAnID).ToList();
            }

            if (duAnRequest.TrangThaiID != null)
            {
                result = result.Where(x => x.TrangThaiID == duAnRequest.TrangThaiID).ToList();
            }

            return result;
        }


        public List<DuAn> GetAllDuAn()
        {
            var listDuAn = _context.DuAns.Where(x => x.IsDeleted == false).Include(_=>_.TrangThai).ToList();

            return listDuAn;
        }

        public DuAn? GetById(Guid id)
        {
            var result = _context.DuAns.Where(x => x.Id == id && x.IsDeleted == false).Include(_=>_.TrangThai).FirstOrDefault();

            return result;
        }

        public DuAn PostService(DuAn duAn)
        {
            try
            {
                duAn.CreatedUser_ID = 112233;
                duAn.CreatedDate = DateTime.Now;
                duAn.TrangThaiID = (short)ViewModel.Enum.TrangThai.DangXuLy;

                _context.DuAns.Add(duAn);
                _context.SaveChanges();
                return duAn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving changes to the database:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return null;
        }

        public DuAn? UpdateDuAn(DuAnUpdateRequest request)
        {
            var duAn = _context.DuAns.Where(x => x.Id == request.Id).FirstOrDefault();

            if (duAn != null)
            {
                _mapper.Map(request, duAn);

                _context.SaveChanges();
            }

            var result = _context.DuAns.Where(x => x.Id == request.Id).FirstOrDefault();

            return result;
        }

        public DuAn? UpdateTrangThaiDuAn(DuAnUpdateTrangThaiRequest request)
        {
            var duAn = _context.DuAns.Where(x => x.Id == request.Id && x.IsDeleted == false).FirstOrDefault();
            
            if (duAn != null)
            {
                _mapper.Map(request, duAn);

                _context.SaveChanges();
            }

            var result = _context.DuAns.Where(x => x.Id == request.Id).FirstOrDefault();

            return result;
        }
    }
}
