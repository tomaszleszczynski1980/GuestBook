using Microsoft.EntityFrameworkCore;

namespace GuestBook.Data
{
    public class GuestBookContext : DbContext
    {
        public GuestBookContext(DbContextOptions<GuestBookContext> options) : base(options)
        {
        }
        
        public DbSet<Models.GuestBook> GuestBook { get; set; } 
    }
}