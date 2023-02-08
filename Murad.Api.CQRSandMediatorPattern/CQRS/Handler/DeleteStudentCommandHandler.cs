using MediatR;
using Murad.Api.CQRSandMediatorPattern.CQRS.Command;
using Murad.Api.CQRSandMediatorPattern.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Handler
{

    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly StudentContext _studentContext;

        public DeleteStudentCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var getId = await _studentContext.Set<Student>().FindAsync(request.Id);
              _studentContext.Remove(getId);
             await _studentContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
