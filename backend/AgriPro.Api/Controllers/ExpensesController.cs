using AgriPro.Api.Data;
using AgriPro.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriPro.Api.Controllers;

[ApiController]
[Route("api/projects/{projectId:int}/expenses")]
public class ExpensesController : ControllerBase
{
    private readonly AgriProDbContext _context;

    public ExpensesController(AgriProDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses(int projectId)
    {
        var expenses = await _context.Expenses
            .Where(e => e.ProjectId == projectId)
            .AsNoTracking()
            .ToListAsync();
        return Ok(expenses);
    }

    [HttpPost]
    public async Task<ActionResult<Expense>> CreateExpense(int projectId, Expense expense)
    {
        expense.ProjectId = projectId;
        _context.Expenses.Add(expense);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetExpenses), new { projectId }, expense);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateExpense(int projectId, int id, Expense expense)
    {
        if (id != expense.Id)
        {
            return BadRequest();
        }

        expense.ProjectId = projectId;
        _context.Entry(expense).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteExpense(int projectId, int id)
    {
        var expense = await _context.Expenses.FirstOrDefaultAsync(e => e.Id == id && e.ProjectId == projectId);
        if (expense is null)
        {
            return NotFound();
        }

        _context.Expenses.Remove(expense);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
