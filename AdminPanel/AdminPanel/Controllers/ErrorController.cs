using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
