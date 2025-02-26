using book_web.Models;
using book_web.Services;
using Microsoft.AspNetCore.Mvc;

public class CustomerServiceController : Controller
{
    private readonly IEmailService _emailService;

    private readonly ICusService _customerService;

    public CustomerServiceController(IEmailService emailService,ICusService customerService)
    {
        _emailService = emailService;
        _customerService = customerService;
    }

    // Display FAQs
    public IActionResult FAQs()
    {
        var faqs = _customerService.GetFAQs();
        return View(faqs);
    }

    // Display contact page with contact form and store information
    public IActionResult Contact()
    {
        var contactInfo = _customerService.GetContactInformation();
        return View(contactInfo);
    }

    // Handle the contact form submission
    [HttpPost]
    public IActionResult Contact(ContactForm form)
    {
        if (ModelState.IsValid)
        {
            // Here, you can send an email, log the message, or do other actions
            TempData["SuccessMessage"] = "Your message has been sent!";
            return RedirectToAction("Contact");
        }

        // If the form is not valid, return the view with the error message
        return View(form);
    }
    [HttpPost]
    public IActionResult SendEmail(ContactForm form)
    {
        if (ModelState.IsValid)
        {
            // Send email
            _emailService.SendEmail("support@bookstore.com", "Customer Inquiry", $"Name: {form.Yourname}\nEmail: {form.Email}\nMessage: {form.Message}");

            TempData["SuccessMessage"] = "Your message has been sent!";
            return RedirectToAction("Contact");
        }

        return View("Contact", form);
    }
}

