using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ProductCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
