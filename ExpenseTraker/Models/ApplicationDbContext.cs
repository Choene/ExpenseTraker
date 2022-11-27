using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ExpenseTraker.Models
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
