using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Application.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetBooksAsync();
            return View(books);
        }
    }
}
