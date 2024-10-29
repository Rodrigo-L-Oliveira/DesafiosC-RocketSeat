using Microsoft.EntityFrameworkCore;
using bookStoreAPI.Models;

namespace bookStoreAPI.Data
{
    public class bookStoreContext : DbContext
    {
        public bookStoreContext(DbContextOptions<bookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
