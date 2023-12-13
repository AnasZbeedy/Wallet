using Microsoft.EntityFrameworkCore;

namespace Expense_Track.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        { 

        }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
