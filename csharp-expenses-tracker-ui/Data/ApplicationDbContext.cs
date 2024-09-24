using csharp_expenses_tracker_ui.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_expenses_tracker_ui.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
