using Microsoft.AspNetCore.Mvc;

namespace MentorAppFrontToBack.Controllers
{
    public class DataDemoController : Controller
    {
        // ViewData ve ViewBag 
        public IActionResult Index()
        {
            ViewData["Message"] = "Bu ViewData ilə gələn mesajdır";
            ViewBag.Note = "Bu ViewBag ilə gələn qeyddir";

            return View();
        }

        // TempData 
        public IActionResult SendTempData()
        {
            TempData["Alert"] = "Bu TempData mesajıdır (redirect zamanı görünəcək)";
            return RedirectToAction("ShowTempData");
        }

        public IActionResult ShowTempData()
        {
            return View();
        }
    }
}

