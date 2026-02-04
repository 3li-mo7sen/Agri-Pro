using AgriPro.Api.Data;
using AgriPro.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriPro.Api.Controllers;

[ApiController]
[Route("api/investments")]
public class InvestmentsController : ControllerBase
{
    private readonly AgriProDbContext _context;

    public InvestmentsController(AgriProDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Investment>>> GetInvestments()
    {
        var investments = await _context.Investments
            .Include(i => i.Project)
            .AsNoTracking()
            .ToListAsync();
        return Ok(investments);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Investment>> GetInvestment(int id)
    {
        var investment = await _context.Investments
            .Include(i => i.Project)
            .AsNoTracking()
            .FirstOrDefaultAsync(i => i.Id == id);
        return investment is null ? NotFound() : Ok(investment);
    }

    [HttpPost]
    public async Task<ActionResult<Investment>> CreateInvestment(Investment investment)
    {
        var project = await _context.Projects.FindAsync(investment.ProjectId);
        if (project is null)
        {
            return BadRequest("Project not found.");
        }

        project.CurrentFunding += investment.Amount;
        _context.Investments.Add(investment);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetInvestment), new { id = investment.Id }, investment);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteInvestment(int id)
    {
        var investment = await _context.Investments.FindAsync(id);
        if (investment is null)
        {
            return NotFound();
        }

        _context.Investments.Remove(investment);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
