using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class GiaiphuongtrinhController : Controller
    {
        // GET: giaiphuongtrinh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(double hesoA, double hesoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}