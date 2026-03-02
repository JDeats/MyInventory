using Application.Items.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ItemsController(IMediator mediator)  : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Item>>> GetItems()
    {
        return await mediator.Send(new GetItemList.Query());
    }
}
