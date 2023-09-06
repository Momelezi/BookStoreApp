using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Models;

namespace BookStoreApp.Data
{
    public class BookStoreAppContext : DbContext
    {
        public BookStoreAppContext (DbContextOptions<BookStoreAppContext> options)
            : base(options)
        {
           
        }

        public DbSet<Book> Books { get; set; } 

    }
}
