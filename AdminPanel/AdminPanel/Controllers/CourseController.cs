using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
