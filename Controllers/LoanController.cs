
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class LoanController : Controller
{
    private readonly BankDbContext _context;

    public LoanController(BankDbContext context)
    {
        _context = context;
    }

    [HttpGet("/loans")]
    public async Task<IActionResult> loanItems()
    {
        var loanItems = await _context.Set<LoanItem>().ToListAsync();
        return View(loanItems);
    }
    
}