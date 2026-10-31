using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PustokMVCApp.Settings;

namespace PustokMVCApp.Controllers
{
    public class BasketController(/*IOptions<EmailSetting> emailSetting*/
        /*IOptionsMonitor<EmailSetting> emailMonitor*/
        IOptionsSnapshot<EmailSetting> emailSnapshot) : Controller
    {
        public IActionResult Index()
        {
            //return Content(emailSetting.Value.To);
            //return Content(emailMonitor.CurrentValue.To);
            return Content(emailSnapshot.Value.To);
        }
    }
}