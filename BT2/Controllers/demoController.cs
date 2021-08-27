using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT2.Models;

namespace BT2.Controllers
{
    public class demoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double hesoA, double hesoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}

    
