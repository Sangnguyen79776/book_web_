using book_web.Services;
using Microsoft.AspNetCore.Mvc;

public class EventsController : Controller
{
    private readonly IEventServices _eventsService;

    public EventsController(IEventServices eventsService)
    {
        _eventsService = eventsService;
    }

    // Display the upcoming events agenda
    public IActionResult Index()
    {
        var events = _eventsService.GetUpcomingEvents();
        return View(events);
    }

    // Display book clubs and how to join them
    public IActionResult BookClubs()
    {
        var bookClubs = _eventsService.GetBookClubs();
        return View(bookClubs);
    }
}


