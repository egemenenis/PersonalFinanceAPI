using Microsoft.EntityFrameworkCore;
using PersonalFinanceAPI.Core.Entities;

namespace PersonalFinanceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionCategory> TransactionCategories { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Saving> Savings { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}