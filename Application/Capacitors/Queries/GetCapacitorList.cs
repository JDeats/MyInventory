using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Capacitors.Queries;

public class GetCapacitorList
{
    public class Query : IRequest<List<Capacitor>> {}

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Capacitor>>
    {
        public async Task<List<Capacitor>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Capacitors.ToListAsync(cancellationToken);
        }
    }
}
