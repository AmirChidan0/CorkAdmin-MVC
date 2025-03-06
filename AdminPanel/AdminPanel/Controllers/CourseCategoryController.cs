using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class CourseCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
