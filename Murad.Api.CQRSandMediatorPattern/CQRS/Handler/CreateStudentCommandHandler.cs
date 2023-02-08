using MediatR;
using Murad.Api.CQRSandMediatorPattern.CQRS.Command;
using Murad.Api.CQRSandMediatorPattern.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Handler
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly StudentContext _context;

        public CreateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
          await _context.AddAsync(new Student { Name = request.Name, Surname = request.Surname, Age = request.Age, Group = request.Group });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
