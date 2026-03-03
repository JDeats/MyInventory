using Domain;
using MediatR;
using Persistence;

namespace Application.Capacitors.Queries;

public class GetCapacitor
{
    public class Query : IRequest<Capacitor>
    {
        public required int Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, Capacitor>
    {
        public async Task<Capacitor> Handle(Query request, CancellationToken cancellationToken)
        {
            var cap = await context.Capacitors.FindAsync([request.Id], cancellationToken) 
                ?? throw new Exception("Capacitor not found");
            return cap;
        }
    }
}
