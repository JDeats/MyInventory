using Domain;
using MediatR;
using Persistence;

namespace Application.Capacitors.Commands;

public class CreateCapacitor
{
    public class Command : IRequest<int>
    {
        public required Capacitor Capacitor { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command, int>
    {
        public async Task<int> Handle(Command request, CancellationToken cancellationToken)
        {
            context.Capacitors.Add(request.Capacitor);
            await context.SaveChangesAsync(cancellationToken);
            return request.Capacitor.Id;
        }
    }
}
