using Microsoft.AspNetCore.Mvc;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Danhmuc;
using QuanLyDuAnDauTu.Ser.Services;

namespace QuanLyDuAnDauTu.Ser.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DanhMucController : ControllerBase
    {
        private IDanhMucService danhMucService;

        public DanhMucController(IDanhMucService danhMucService)
        {
            this.danhMucService = danhMucService;
        }


        [HttpGet(nameof(GetAllTinhThanh))]
        public IActionResult GetAllTinhThanh()
        {
            try
            {
                var result = danhMucService.GetAllTinhThanh();

                return Ok(result);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetQuanHuyenByTinhThanhId))]
        public IActionResult GetQuanHuyenByTinhThanhId(int id)
        {
            try
            {
                var result = danhMucService.GetQuanHuyenByTinhThanhId(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetPhuongXaByQuanHuyenId))]
        public IActionResult GetPhuongXaByQuanHuyenId(int id)
        {
            try
            {
                var result = danhMucService.GetPhuongXaByQuanHuyenId(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetAllDonViDauTu))]
        public IActionResult GetAllDonViDauTu()
        {
            try
            {
                var result = danhMucService.GetAllDonViDauTu();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetAllNguonVon))]
        public IActionResult GetAllNguonVon()
        {
            try
            {
                var result = danhMucService.GetAllNguonVon();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetAllHinhThucQuanLyDuAn))]
        public IActionResult GetAllHinhThucQuanLyDuAn()
        {
            try
            {
                var result = danhMucService.GetAllHinhThucQuanLyDuAn();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetALlNhomDuAn))]
        public IActionResult GetALlNhomDuAn()
        {
            try
            {
                var result = danhMucService.GetAllNhomDuAn();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetAllLoaiDauTu))]
        public IActionResult GetAllLoaiDauTu()
        {
            try
            {
                var result = danhMucService.GetAllLoaiDauTu();

                return Ok(result);
            }   
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetAllTinhChatCntt))]
        public IActionResult GetAllTinhChatCntt()
        {
            try
            {
                var result = danhMucService.GetAllTinhChatCntt();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetAllPhanNhomCntt))]
        public IActionResult GetAllPhanNhomCntt()
        {
            try
            {
                var result = danhMucService.GetAllPhanNhomCntt();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetDonViById))]
        public IActionResult GetDonViById(int id)
        {
            try
            {
                var result = danhMucService.GetDonViById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetNguonVonById))]
        public IActionResult GetNguonVonById(int id)
        {
            try
            {
                var result = danhMucService.GetNguonVonById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetLoaiDauTuById))]
        public IActionResult GetLoaiDauTuById(int id)
        {
            try
            {
                var result = danhMucService.GetLoaiDauTuById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetPhanNhomCnttById))]
        public IActionResult GetPhanNhomCnttById(int id)
        {
            try
            {
                var result = danhMucService.GetPhanNhomCnttById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetTinhChatCnttById))]
        public IActionResult GetTinhChatCnttById(int id)
        {
            try
            {
                var result = danhMucService.GetTinhChatCnttById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetHinhThucQldaById))]
        public IActionResult GetHinhThucQldaById(int id)
        {
            try
            {
                var result = danhMucService.GetHinhThucQldaById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(GetNhomDuAnById))]
        public IActionResult GetNhomDuAnById(int id)
        {
            try
            {
                var result = danhMucService.GetNhomDuAnById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
