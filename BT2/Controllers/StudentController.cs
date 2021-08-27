using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetInfo(string TEN, string TUOI, string LOP)
        {
            ViewBag.TEN = TEN;
            ViewBag.TUOI = TUOI;
            ViewBag.LOP = LOP;
            return View();

        }
    }
}