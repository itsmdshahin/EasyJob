using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobPortal.Infrastructure.Data;
using JobPortal.Core.Models;

namespace JobPortal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    public JobsController(ApplicationDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _db.Jobs.ToListAsync());

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create(Job job)
    {
        job.PostedOn = DateTime.UtcNow;
        _db.Jobs.Add(job);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = job.Id }, job);
    }
}