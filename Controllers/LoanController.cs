
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class LoanController : Controller
{
    private readonly BankDbContext _context;

    public LoanController(BankDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var loanItems = await _context.Set<LoanItem>().ToListAsync();
        return Ok(loanItems);
    }
    
}