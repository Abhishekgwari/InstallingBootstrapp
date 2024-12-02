using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
