using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoMVC.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
