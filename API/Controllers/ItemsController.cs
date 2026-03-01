using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ItemsController(AppDbContext context)  : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Item>>> GetItems()
    {
        return await context.Items.ToListAsync();
    }
}
