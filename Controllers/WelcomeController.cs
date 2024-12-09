using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class WelcomeController : Controller
    {
        string name = "Mohamed";
        public IActionResult Index()
        {
            return View(model: name);
        }
    }
}
