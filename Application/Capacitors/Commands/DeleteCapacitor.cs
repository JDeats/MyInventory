using Domain;
using MediatR;
using Persistence;

namespace Application.Capacitors.Commands;

public class DeleteCapacitor
{
    public class Command : IRequest
    {
        public required int Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            Capacitor? cap = await context.Capacitors.FindAsync([request.Id], cancellationToken) 
                ?? throw new Exception("Cannot find capacitor");
            context.Remove(cap);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
