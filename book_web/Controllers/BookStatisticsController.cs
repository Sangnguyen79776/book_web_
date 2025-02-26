using System.Web.Helpers;
using book_web.Data;
using book_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace book_web.Controllers
{
    public class BookStatisticsController : Controller
    {
        private readonly Book_webContext _context;
        private readonly IHubContext<StatisticHub> _hubContext;
        public BookStatisticsController(Book_webContext context, IHubContext<StatisticHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        public async Task<IActionResult> Index1()
        {
            var statistics = await _context.BookStatistics
          .Include(bs => bs.Book)  // Include book details if necessary
          .OrderByDescending(bs => bs.Date)  // Order by date
          .Take(30)  // Limit to the latest 30 records (adjust as needed)
          .ToListAsync();

            // Construct the BookStatisticViewModel
            var viewModel = new BookStatisticViewModel
            {
                //Title =statistics.Select(s=>s.Book.BookTitle).ToList(),
                Book = statistics.Select(statistics => statistics.Book).ToList(),
                Labels = statistics.Select(s => s.Date.ToString("yyyy-MM-dd")).ToArray(),  // Extract dates
                Views = statistics.Select(s => s.Views).ToArray(),  // Extract views data
                Sales = statistics.Select(s => s.Sales).ToArray()   // Extract sales data
            };

            return View(viewModel);  // Pass the view model to the view
        }
        public async Task AddBookStatisticAsync(BookStatistics bookStatistic)
        {
            _context.BookStatistics.Add(bookStatistic);
            await _context.SaveChangesAsync();

            // Fetch updated data
            var statistics = await _context.BookStatistics
                .Include(bs => bs.Book)
                .Include(bs => bs.Book.Genre)
                .OrderByDescending(bs => bs.Date)
                .Take(30)
                .ToListAsync();

            var chartData = new
            {
                labels = statistics.Select(s => s.Date.ToString("yyyy-MM-dd")).ToArray(),
                views = statistics.Select(s => s.Views).ToArray(),
                sales = statistics.Select(s => s.Sales).ToArray()
            };

            // Send updated data to all clients
            //await _hubContext.Clients.All.SendAsync("ReceiveStatisticsData", Json.Serialize(chartData));
        }
        public async Task<IActionResult> Add()
        {
            // Get the list of books to choose from
            //    ViewBag.Books = new SelectList(_context.Book, "BookId", "BookTitle");
            //    return View();
            //}
            var books = await _context.Book.ToListAsync();

            // Pass the list of books to the view via ViewData
            ViewData["Books"] = books;

            return View();
        }
        // POST: BookStatistics/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(BookStatistics bookStatistic)
        {
            if (ModelState.IsValid)
            {
                // Add the BookStatistic to the database
                _context.BookStatistics.Add(bookStatistic);
                await _context.SaveChangesAsync();

                // Send the updated statistics to all connected clients via SignalR
                var statistics = await _context.BookStatistics
                    .Include(bs => bs.Book)
                    .OrderByDescending(bs => bs.Date)
                    .Take(30)  // Example: Get the latest 30 statistics records
                    .ToListAsync();

                var viewModel = new BookStatisticViewModel
                {
                    Labels = statistics.Select(s => s.Date.ToString("yyyy-MM-dd")).ToArray(),
                    Views = statistics.Select(s => s.Views).ToArray(),
                    Sales = statistics.Select(s => s.Sales).ToArray()
                };


                // Send updated chart data to all clients via SignalR
                await _hubContext.Clients.All.SendAsync("ReceiveStatisticsData", viewModel);

                // Redirect to the Index page (or wherever you want after submission)
                return RedirectToAction(nameof(Index));
                //if (ModelState.IsValid)
                //{
                //    // Ensure the selected BookId exists in the database
                //    var book = await _context.Book.FindAsync(bookStatistic.BookId);
                //    if (book == null)
                //    {
                //        // Handle the error if the book is not found
                //        ModelState.AddModelError("BookId", "Selected book does not exist.");
                //        ViewData["Books"] = await _context.Book.ToListAsync();
                //        return View(bookStatistic);
                //    }

                //    // Create a new BookStatistic
                //    _context.Add(bookStatistic);
                //    await _context.SaveChangesAsync();

                //    // Redirect to the Index view (or any other view you prefer)
                //    return RedirectToAction(nameof(Index));
                //}

                // If model state is invalid, redisplay the form
                //ViewData["Books"] = await _context.Book.ToListAsync();
                //return View(bookStatistic);
            }

            // If model state is not valid, reload the form
            ViewBag.Books = new SelectList(_context.Book, "BookId", "BookTitle", bookStatistic.BookId);
            return View(bookStatistic);
        }
    }

}
   
   

  
