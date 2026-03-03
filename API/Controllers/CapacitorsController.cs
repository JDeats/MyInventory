using Application.Capacitors.Commands;
using Application.Capacitors.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CapacitorsController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Capacitor>>> GetCapacitors(CancellationToken ct)
    {
        return await Mediator.Send(new GetCapacitorList.Query(), ct);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Capacitor>> GetCapacitor(int id, CancellationToken ct)
    {
        return await Mediator.Send(new GetCapacitor.Query{Id = id}, ct);
    }

    [HttpPost]
    public async Task<ActionResult<int>> AddCapacitor(Capacitor cap, CancellationToken ct)
    {
        return await Mediator.Send(new CreateCapacitor.Command{Capacitor = cap}, ct);
    }

    [HttpPut]
    public async Task<ActionResult> EditCapacitor(Capacitor cap, CancellationToken ct)
    {
        await Mediator.Send(new EditCapacitor.Command{Capacitor = cap}, ct);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCapacitor(int id, CancellationToken ct)
    {
        await Mediator.Send(new DeleteCapacitor.Command{Id = id}, ct);
        return Ok();
    }
}
