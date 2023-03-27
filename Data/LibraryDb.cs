using Microsoft.EntityFrameworkCore;
using WebAppLibrary.Models;

namespace WebAppLibrary.Data
{
    public class LibraryDb:DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public LibraryDb(DbContextOptions<LibraryDb> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Book>().HasIndex(b => b.Iban).IsUnique();
        }
    }
}
