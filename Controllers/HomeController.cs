using csharp_blog_frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharp_blog_frontend.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(id);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateFile()
        {
            return View();
        }

       

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(id);
        }
    }
}