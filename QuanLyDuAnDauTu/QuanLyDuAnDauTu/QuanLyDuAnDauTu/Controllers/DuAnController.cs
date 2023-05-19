using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
        public class DuAnController : Controller
        {
            // GET: DuAn

            public ActionResult ToTrinh()
            {
                return View();
            }

            public ActionResult TaoDuAn(Guid? Id, string view)
            {
                ViewBag.Id = Id;
                ViewBag.Skin = view;
            
                return View();
            }
        
        public ActionResult DanhSachDuAn_So4T()
        {
            return View();
        }

        public ActionResult DanhSachDuAn_QHSBN()
        {
            return View();
        }
    }
}
