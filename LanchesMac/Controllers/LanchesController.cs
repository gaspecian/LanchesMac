using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LanchesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
