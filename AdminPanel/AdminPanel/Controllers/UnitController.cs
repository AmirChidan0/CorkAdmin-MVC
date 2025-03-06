using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
