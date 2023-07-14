using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppLibrary.Data;
using WebAppLibrary.Models;

namespace WebAppLibrary.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly WebAppLibraryContext _context;

        public IndexModel(WebAppLibraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ViewData["message"] = "This Message...";
           
            if (_context.Book != null)
            {
              
                    Book = await _context.Book.ToListAsync();
              
              
            }
        }

        public async Task OnPostTitleAsync(string searchText)
        {
            Book = await _context.Book.Where(b => b.Title.Contains(searchText)).ToListAsync();
          
        }
        public async Task OnPostAuthorAsync(string searchText)
        {
            Book = await _context.Book.Where(b => b.Author.Contains(searchText)).ToListAsync();
        }
        public IActionResult OnPostFilter()
        {
            return RedirectToPage("/Books/Index");
        }
    }
}
