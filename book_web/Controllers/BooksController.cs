using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using book_web.Data;
using book_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;
using book_web.Services;
using Microsoft.AspNetCore.SignalR;
using book_web.Dependency_Injection;
using PagedList;
using System.Drawing.Printing;


namespace book_web.Controllers
{
    [Authorize]
    public class BooksController : Controller

    {
        private readonly Book_webContext _context;
        private readonly IMemoryCache _cache;
        private readonly IBookRecommendationService _bookRecommendationService;
        private readonly IHubContext<IventoryHub> _hubContext;
        private readonly IBookRespository _bookRespository;
        private readonly IBookService _bookService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        //private readonly IHubContext<StatisticHub> _hub;

        public BooksController(Book_webContext context, IMemoryCache cache, IBookRecommendationService bookRecommendationService
            , IHubContext<IventoryHub> hubContext, IBookRespository bookRespository
            , IBookService bookService, IWebHostEnvironment webHostEnvironment)//, IHubContext<StatisticHub> hub)
        {
            _context = context;
            _cache = cache;
            _bookRecommendationService = bookRecommendationService;
            _hubContext = hubContext;
            _bookRespository = bookRespository;
            _bookService = bookService;
            _webHostEnvironment = webHostEnvironment;
            //_hub = hub;
        }
        //public async Task<IActionResult> UpdateBookStatistic(int bookId, BookStatistics stats)
        //{
        //    var existingStats = await _context.BookStatistics
        //                                 .FirstOrDefaultAsync(b => b.BookId == bookId);

        //    if (existingStats != null)
        //    {
        //        existingStats.Views = stats.Views;
        //        existingStats.Purchases = stats.Purchases;
        //        existingStats.LastUpdated = DateTime.Now;
        //        _context.BookStatistics.Update(existingStats);
        //    }
        //    else
        //    {
        //        stats.BookId = bookId;
        //        stats.LastUpdated = DateTime.Now;
        //        _context.BookStatistics.Add(stats);
        //    }

        //    await _context.SaveChangesAsync();

        //    // Notify all connected clients (real-time updates)
        //    await _hubContext.Clients.All.SendAsync("ReceiveStatistics", bookId, stats.Views, stats.Purchases);

        //    return RedirectToAction("Details", new { id = bookId });
        //}
        public async Task<IActionResult> RecentBooks()
        {
            const string cacheKey = "recentBooks";
            if (!_cache.TryGetValue(cacheKey, out List<Book> recentBooks))
            {
                recentBooks = await _context.Book
                    .OrderByDescending(b => b.BookId)
                    .Take(5)  //take 5 latest book
                    .ToListAsync();
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
                };
                _cache.Set(cacheKey, recentBooks, cacheOptions);
            }
            return View(recentBooks);
        }
        // GET: Books
        [Authorize]
        public async Task<IActionResult> Index(int page = 1, string sortOrder="desc" , string searchString="" )
        {
            int pageSize = 10; // define number of books display in each pages 
          
            var totalBooks = await _context.Book.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalBooks / pageSize);

            // Get book list and perform search function
            IQueryable<Book> booksQuery = _context.Book.Include(b => b.Genre);

            //var booksWithGenres = _context.Book
            //.Join(_context.Genre,
            // b => b.GenreId,
            //g => g.GenreId,
            //(b, g) => new { Book = b, Genre = g }).ToList();

            // Check if have any search results 
            // Search by exactly keyword 
            if (!string.IsNullOrEmpty(searchString))
            {
                //
                //var filteredBooks = booksWithGenres
                //.Where(ti => ti.Book.BookTitle.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                //  ti.Genre.GenreName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                //.ToList();

                booksQuery = booksQuery.Where(b =>
                 b.BookTitle.Contains(searchString) ||
                // //, StringComparison.OrdinalIgnoreCase) || // Search by book title
                 b.Genre.GenreName.Contains(searchString)
                //,
                //StringComparison.OrdinalIgnoreCase) // search by genre 
                );
            }

                // Sắp xếp theo giá
                if (sortOrder == "asc")
            {
                booksQuery = booksQuery.OrderBy(b => b.BookPrice); // Sort price by ascending
            }
            else
            {
                booksQuery = booksQuery.OrderByDescending(b => b.BookPrice); // sort price by descending 
            }

            var books = await booksQuery 
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var viewModel = new BookViewModel
            {
                Book = books,
                CurrentPage = page,
                TotalPages = totalPages,
                SortOrder = sortOrder,
                SearchString = searchString // return a searchString value 
            };
            


            return View(viewModel);
           
        }
       
        

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName");
            return View(book);
        }

        // GET: Books/Create
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Book book, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra nếu có ảnh được tải lên
                if (image != null && image.Length > 0)
                {
                    var fileName = Path.GetFileName(image.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");  // Lưu ảnh trong thư mục wwwroot/images
                    var filePath = Path.Combine(uploadPath, fileName);

                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }

                    book.BookCover = "/images/" + fileName;  // Đường dẫn tương đối cho ảnh
                }

                _context.Book.Add(book);  // Thêm sách mới vào cơ sở dữ liệu
                _context.SaveChanges();  // Lưu thay đổi

                return RedirectToAction(nameof(Index));  // Quay lại trang index
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreId", book.GenreId);

            return View(book);
        }
        // Nếu có lỗi, hiển thị lại form
                                //public async Task<IActionResult> Create([Bind("BookId,BookTitle,BookPrice,BookCover,Author,Rating,SalesCount" +
                                //    ",StockQuantity,GenreId,DateAdded,IsLimitedEdition,PublishedDate,LastUpdated")] Book book,IFormFile BookCover)
                                //{
                                //    if (ModelState.IsValid)
                                //    {
                                //        //validate image is valid or not
                                //        if (BookCover != null && BookCover.Length > 0)
                                //        {
                                //            //set new image file name
                                //            //Note: use Guid to generate unique file name
                                //            var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(BookCover.FileName);
                                //            //set image file location
                                //            //Note: create a subfolder named "images" in "wwwroot" to store all images
                                //            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

            //            using (var stream = new FileStream(filePath, FileMode.Create))
            //            {
            //                //copy (upload) image file from orignal location to project folder
            //                BookCover.CopyTo(stream);
            //            }

            //            //set image file name for book cover
            //            book.BookCover = "/images/" + fileName;
            //        }
            //        _context.Book.Add(book);
            //        await _context.SaveChangesAsync();
            //        return RedirectToAction(nameof(Index));
            //    }
            //    ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName", book.GenreId);
            //    return View(book);
            //}

            // GET: Books/Edit/5
            [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreId", book.GenreId);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,BookTitle,BookPrice,Author,Rating,SalesCount" +
            ",StockQuantity,GenreId,DateAdded,IsLimitedEdition,PublishedDate,LastUpdated")] Book book,IFormFile BookCover)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (BookCover != null && BookCover.Length > 0)
                    {
                        //set new image file name
                        //Note: use Guid to generate unique file name
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(BookCover.FileName);
                        //set image file location
                        //Note: create a subfolder named "images" in "wwwroot" to store all images
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            //copy (upload) image file from orignal location to project folder
                            BookCover.CopyTo(stream);
                        }

                        //set image file name for book cover
                        book.BookCover = "/images/" + fileName;
                    }
                    //use the existing image file if no image file is uploaded
                    else
                    {
                        var existingBook = _context.Book.AsNoTracking().FirstOrDefault(b => b.BookId == book.BookId);
                        book.BookCover = existingBook.BookCover;
                    }
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName", book.GenreId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if (book != null)
            {
                _context.Book.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.BookId == id);
        }
        [HttpGet]
       // public async Task<IActionResult> SearchByTitle(string title)
        //{
            
        //}

       // public async Task<IActionResult> SortPriceAsc()
        //{
           // var books = _context.Book.Include(b => b.Genre).OrderBy(b => b.BookPrice);
           // return View("Index", await books.ToListAsync());
        //}

        //public async Task<IActionResult> SortPriceDesc()
        //{
        //    var books = _context.Book.Include(b => b.Genre).OrderByDescending(b => b.BookPrice);
        //    return View("Index", await books.ToListAsync());
        //}
        public IActionResult Recommendations()
        {
            var bestSellers = _bookRecommendationService.GetBestSellers();
            var newReleases = _bookRecommendationService.GetNewReleases();
            var staffPicks = _bookRecommendationService.GetStaffPicks();

            var model = new BookRecommendationsViewModel
            {
                BestSellers = bestSellers,
                NewReleases = newReleases,
                StaffPicks = staffPicks
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStock(int bookId, int quantity)
        {
            if (quantity <= 0) return BadRequest();

            await _bookRespository.UpdateBookStockAsync(bookId, quantity);
            await _hubContext.Clients.All.SendAsync("StockUpdated", bookId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult AddBook(Book book, IFormFile file) {
            if (ModelState.IsValid) 
            { 
                _bookService.Upload(book, file);
                _context.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));


            }
        return View(book);
        
        
        }
        public IActionResult Editbook(Book book, IFormFile file)
        {

            if (ModelState.IsValid)
            {
                _bookService.Upload(book, file);
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));


            }
            return View(book);


        }
      
    }
}
