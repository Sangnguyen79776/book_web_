using Microsoft.AspNetCore.Mvc;

namespace book_web.Controllers
{
    public class ChatHubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
