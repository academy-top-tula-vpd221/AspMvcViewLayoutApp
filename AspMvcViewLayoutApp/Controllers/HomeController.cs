using Microsoft.AspNetCore.Mvc;

namespace AspMvcViewLayoutApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Gallery() => PartialView();
    }
}
