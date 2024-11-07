using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTNTHAM_2210900124_PRJ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Chào Mừng bạn đến với shop PuPest";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Bạn cần gì giúp đỡ hãy nói với shop";

            return View();
        }
    }
}