using Lesson06_Theroy_01.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Lesson06_Theroy_01.Models.BookManagementContext
{
    public class BookManagementContext : DbContext
    {

        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

    }
}
