using Microsoft.AspNetCore.Mvc;

namespace QuanLyDuAnDauTu.Ser.Controllers
{
    public class BaseAPIController<T, TKey> : ControllerBase where T : class
    {
        public BaseAPIController() { }

        //[HttpPost(nameof(Create))]
        //public virtual IActionResult Create (T entity)
        //{
        //    ResultApi = new ResultApi();

        //}
    }
}
