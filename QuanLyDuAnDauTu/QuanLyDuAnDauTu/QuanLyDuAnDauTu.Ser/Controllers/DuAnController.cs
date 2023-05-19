using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyDuAnDauTu.Ser.Domain.Entities.SqlServerCCKL.Duan;
using QuanLyDuAnDauTu.Ser.Services;
using QuanLyDuAnDauTu.Ser.ViewModel.DuAnVM.Requests;
using System.Linq.Expressions;

namespace QuanLyDuAnDauTu.Ser.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DuAnController : ControllerBase
    {
        private IDuAnService duAnService;

        public DuAnController (IDuAnService service)
        {
            duAnService = service;
        }

        [HttpGet(nameof(GetProjectById))]
        public IActionResult GetProjectById(Guid id)
        {
            try
            {
                DuAn? result = duAnService.GetById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(nameof(PostProject))]   
        public IActionResult PostProject([FromBody] DuAn duAn)
        {
            try
            {
                var data = duAnService.PostService(duAn);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetAllDuAn))]
        public IActionResult GetAllDuAn()
        {
            try
            {
                var result = duAnService.GetAllDuAn();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost(nameof(GetDuAnBySearch))]
        public IActionResult GetDuAnBySearch([FromBody] DuAnSearchRequest request)
        {
            try
            {
                var result = duAnService.GetDuAnBySearch(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(nameof(SoftDeleteById))]
        public IActionResult SoftDeleteById(Guid id)
        {
            try
            {
                var result = duAnService.SoftDeleteDuAnById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(nameof(UpdateDuAn))]
        public IActionResult UpdateDuAn([FromBody] DuAnUpdateRequest duAn)
        {
            try
            {
                var result = duAnService.UpdateDuAn(duAn);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(nameof(UpdateTrangThaiDuAn))]
        public IActionResult UpdateTrangThaiDuAn([FromBody] DuAnUpdateTrangThaiRequest duAn)
        {
            try
            {
                var result = duAnService.UpdateTrangThaiDuAn(duAn);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
