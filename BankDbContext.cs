using Microsoft.EntityFrameworkCore;

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
    {
    }

    public DbSet<LoanItem> LoanItems { get; set; }
}