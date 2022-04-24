using Microsoft.AspNetCore.Mvc;

namespace Equinox.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
