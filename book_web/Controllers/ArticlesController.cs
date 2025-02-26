using book_web.Data;
using book_web.Models;
using book_web.Services;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace book_web.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IContentFetchingService _contentFetchingService;
        private readonly Book_webContext _context;
        public ArticlesController(IContentFetchingService contentFetchingService,Book_webContext context)
        {
            _contentFetchingService = contentFetchingService;
            _context = context;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            ViewData["Category"] = new SelectList("Literature", "Interview", "Review");
            ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookTitle");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Admin")]
        public IActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(article);

        }
        public IActionResult Details(int id)
        {
            var article = _contentFetchingService.GetArticles().FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            var reviews = _contentFetchingService.GetBookReviews(article.BookId ?? 0);

            var viewModel = new ArticleDetailsViewModel
            {
                Article = article,
                Reviews = reviews
            };

            return View(viewModel);
        }

        // Display author profile with articles
        public IActionResult Author(int authorId)
        {
            var author = _contentFetchingService.GetAuthorWithArticles(authorId);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }
        public IActionResult Index()
        {
            return View(_contentFetchingService.GetArticles());
        }
    }
}
