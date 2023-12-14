using Microsoft.AspNetCore.Mvc;
using paintcompanyrepository.Models;
using System.Diagnostics;

namespace paintcompanyrepository.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }


    }
}