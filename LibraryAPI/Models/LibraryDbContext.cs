using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Book 1", Description = "Description 1", Author = "Author 1", Rating = 4.5, CoverUrl = "https://example.com/book1" },
                new Book { Id = 2, Title = "Book 2", Description = "Description 2", Author = "Author 2", Rating = 3.8, CoverUrl = "https://example.com/book2" },
                new Book { Id = 3, Title = "Book 3", Description = "Description 3", Author = "Author 3", Rating = 4.2, CoverUrl = null }
                );
        }
    }
}
