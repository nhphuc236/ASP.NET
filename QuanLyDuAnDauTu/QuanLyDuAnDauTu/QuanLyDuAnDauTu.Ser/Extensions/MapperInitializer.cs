using AutoMapper;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan;
using QuanLyDuAnDauTu.Ser.ViewModel.DuAnVM.Requests;
using QuanLyDuAnDauTu.Ser.ViewModel.DuAnVM.Response;

namespace QuanLyDuAnDauTu.Ser.Extensions
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer ()
        {
            //DuAn
            //Response
            //CreateMap<DuAn, DuAnResponse>()
            //    .ForMember(des => des.TenTrangThai, opt => opt.MapFrom(src => src.TrangThai != null ? src.TrangThai.TenTrangThai : ""));

            //UpdateDuAn
            CreateMap<DuAnUpdateRequest, DuAn>();

            //Update Trang Thai Du An
            CreateMap<DuAnUpdateTrangThaiRequest, DuAn>();
            
        }
    }
}
