using BookomaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookomaMVC.Context
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


      public DbSet<Book> Books { get; set; }

        
    }
}
