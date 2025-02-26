using book_web.Services;
using Microsoft.AspNetCore.Mvc;

namespace book_web.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        // Display the history of the bookstore

        public IActionResult History()
        {
            var history = _aboutUsService.GetBookstoreHistory();
            return View(history);
        }

        // Display the team members
        public IActionResult Team()
        {
            var teamMembers = _aboutUsService.GetTeamMembers();
            return View(teamMembers);
        }
    }
}
