using Application.Capacitors.Commands;
using Application.Capacitors.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CapacitorsController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Capacitor>>> GetCapacitors()
    {
        return await Mediator.Send(new GetCapacitorList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Capacitor>> GetCapacitor(int id)
    {
        return await Mediator.Send(new GetCapacitor.Query{Id = id});
    }

    [HttpPost]
    public async Task<ActionResult<int>> AddCapacitor(Capacitor cap)
    {
        return await Mediator.Send(new CreateCapacitor.Command{Capacitor = cap});
    }

    [HttpPut]
    public async Task<ActionResult> EditCapacitor(Capacitor cap)
    {
        await Mediator.Send(new EditCapacitor.Command{Capacitor = cap});
        return NoContent();
    }
}
