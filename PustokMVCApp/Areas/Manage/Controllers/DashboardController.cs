using Microsoft.AspNetCore.Mvc;

namespace PustokMVCApp.Areas.Manage.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}