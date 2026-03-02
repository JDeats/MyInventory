using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Items.Queries;

public class GetItemList
{
    public class Query : IRequest<List<Item>> {}

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Item>>
    {
        public async Task<List<Item>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Items.ToListAsync(cancellationToken);
        }
    }
}
