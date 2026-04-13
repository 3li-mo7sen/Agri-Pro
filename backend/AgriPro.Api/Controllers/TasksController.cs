using AgriPro.Api.Data;
using AgriPro.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriPro.Api.Controllers;

[ApiController]
[Route("api/projects/{projectId:int}/tasks")]
public class TasksController : ControllerBase
{
    private readonly AgriProDbContext _context;

    public TasksController(AgriProDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FarmTask>>> GetTasks(int projectId)
    {
        var tasks = await _context.FarmTasks
            .Where(t => t.ProjectId == projectId)
            .AsNoTracking()
            .ToListAsync();
        return Ok(tasks);
    }

    [HttpPost]
    public async Task<ActionResult<FarmTask>> CreateTask(int projectId, FarmTask task)
    {
        task.ProjectId = projectId;
        _context.FarmTasks.Add(task);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTasks), new { projectId }, task);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTask(int projectId, int id, FarmTask task)
    {
        if (id != task.Id)
        {
            return BadRequest();
        }

        task.ProjectId = projectId;
        _context.Entry(task).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTask(int projectId, int id)
    {
        var task = await _context.FarmTasks.FirstOrDefaultAsync(t => t.Id == id && t.ProjectId == projectId);
        if (task is null)
        {
            return NotFound();
        }

        _context.FarmTasks.Remove(task);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
