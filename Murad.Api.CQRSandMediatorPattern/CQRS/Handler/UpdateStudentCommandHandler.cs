using MediatR;
using Murad.Api.CQRSandMediatorPattern.CQRS.Command;
using Murad.Api.CQRSandMediatorPattern.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Handler
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly StudentContext _context;

        public UpdateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var updatedData = await _context.Students.FindAsync(request.Id);
             updatedData.Name= request.Name ;
             updatedData.Surname = request.Surname;
            updatedData.Age = request.Age;
             updatedData.Group = request.Group;
             await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
