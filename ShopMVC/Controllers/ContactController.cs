using Microsoft.AspNetCore.Mvc;

namespace ShopMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
