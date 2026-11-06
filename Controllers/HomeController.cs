using Microsoft.AspNetCore.Mvc;

namespace WebApplication_empty.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/Home/Index")]
        [Route("/Home/HomePage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
