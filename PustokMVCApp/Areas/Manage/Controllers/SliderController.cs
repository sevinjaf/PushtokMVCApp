using Microsoft.AspNetCore.Mvc;
using PustokMVCApp.Data;

namespace PustokMVCApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController(AppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var sliders = context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Details(Guid id)
        {
            var slider = context.Sliders.FirstOrDefault(s => s.Id == id);
            if (slider is null)
            {
                return NotFound();
            }

            return View(slider);
        }
    }
}