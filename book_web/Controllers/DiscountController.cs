using book_web.Data;
using book_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_web.Controllers
{
    
    public class DiscountController : Controller
    {
        private readonly Book_webContext _context;
        public DiscountController(Book_webContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var discounts = _context.Discount.ToList();
            return View(discounts);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Discount discount) {
            if (ModelState.IsValid)
            {
                _context.Discount.Add(discount);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(discount);

        }
        public IActionResult Edit(int id)
        {
            var discount = _context.Discount.Find(id);
            if (discount == null)
            {
                return NotFound();
            }
            return View(discount);
        }

        // Handle form submission for editing an existing discount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Discount discount)
        {
            if (id != discount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(discount);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Discount.Any(d => d.Id == discount.Id))
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
            return View(discount);
        }
        public ActionResult Delete(int id) { 
            var req=  _context.Discount.FirstOrDefault(d => d.Id == id);
            if(req == null)
            {
                return NotFound();
            }
            _context.Discount.Remove(req);
            _context.SaveChanges();
            return View(req);

        
        }
    }
}
