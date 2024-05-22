using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoMVC.Controllers
{
    public class AulasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
