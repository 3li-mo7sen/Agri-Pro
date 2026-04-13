using AgriPro.Api.Data;
using AgriPro.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriPro.Api.Controllers;

[ApiController]
[Route("api/products/{productId:int}/reports")]
public class ProductReportsController : ControllerBase
{
    private readonly AgriProDbContext _context;

    public ProductReportsController(AgriProDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductReport>>> GetReports(int productId)
    {
        var reports = await _context.ProductReports
            .Where(r => r.ProductId == productId)
            .AsNoTracking()
            .ToListAsync();
        return Ok(reports);
    }

    [HttpPost]
    public async Task<ActionResult<ProductReport>> CreateReport(int productId, ProductReport report)
    {
        report.ProductId = productId;
        _context.ProductReports.Add(report);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetReports), new { productId }, report);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateReport(int productId, int id, ProductReport report)
    {
        if (id != report.Id)
        {
            return BadRequest();
        }

        report.ProductId = productId;
        _context.Entry(report).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
