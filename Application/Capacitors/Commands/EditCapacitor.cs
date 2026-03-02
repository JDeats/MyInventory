using Domain;
using MediatR;
using Persistence;

namespace Application.Capacitors.Commands;

public class EditCapacitor
{
    public class Command : IRequest
    {
        public required Capacitor Capacitor { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            Capacitor? cap = await context.Capacitors.FindAsync([request.Capacitor.Id], cancellationToken) 
                ?? throw new Exception("Cannot find capacitor");
            cap.Description = request.Capacitor.Description;
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
