using Microsoft.EntityFrameworkCore;

public static class DbInitializer
{
    public static void Initialize(BankDbContext context)
    {
        context.Database.Migrate();
        
        var loanItems = context.Set<LoanItem>();

        if(loanItems.Any())
        {
            return; // DB has been seeded
        }   

        loanItems.AddRange(
            new LoanItem
            {
                Name = "주택 담보 대출",
                Amount = 300000000,
                InterestRate = 3.5,
                TermInMonths = 360,
                StartDate = new DateTime(2026, 1, 1),
                EndDate = new DateTime(2056, 1, 1)
            },
            new LoanItem
            {
                Name = "자동차 대출",
                Amount = 50000000,
                InterestRate = 4.2,
                TermInMonths = 60,
                StartDate = new DateTime(2026, 3, 15),
                EndDate = new DateTime(2031, 3, 15)
            },
            new LoanItem
            {
                Name = "생활비 대출",
                Amount = 10000000,
                InterestRate = 6.8,
                TermInMonths = 36,
                StartDate = new DateTime(2026, 5, 10),
                EndDate = new DateTime(2029, 5, 10)
            }
        );

        context.SaveChanges();
    }
}