using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLibrary.Models;

namespace WebAppLibrary.Data
{
    public class WebAppLibraryContext : DbContext
    {
        public WebAppLibraryContext (DbContextOptions<WebAppLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
    }
}
