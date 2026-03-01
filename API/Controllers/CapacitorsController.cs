using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class CapacitorsController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Capacitor>>> GetCapacitors()
    {
        return await context.Capacitors.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult> AddCapacitor(Capacitor cap)
    {
        await context.Capacitors.AddAsync(cap);
        bool result = await context.SaveChangesAsync() > 0;

        if (result) return Ok();
        return BadRequest("Failed to save capacitor");
    }
}
