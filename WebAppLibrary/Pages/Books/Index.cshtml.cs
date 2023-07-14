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
        private readonly WebAppLibrary.Data.WebAppLibraryContext _context;

        public IndexModel(WebAppLibrary.Data.WebAppLibraryContext context)
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
    }
}
