using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
