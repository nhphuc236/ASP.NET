using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDuAnDauTu.Controllers
{
    public class TiepNhanController : Controller
    {
        // GET: TiepNhan
        public ActionResult DanhSach()
        {
            return View();
        }

        public ActionResult TiepNhanHoSo(long? Id, string view)
        {
            ViewBag.Id = Id;
            ViewBag.view = view;

            return View();
        }
    }
}