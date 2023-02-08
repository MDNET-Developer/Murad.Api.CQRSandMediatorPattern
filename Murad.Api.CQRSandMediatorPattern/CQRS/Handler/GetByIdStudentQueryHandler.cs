using MediatR;
using Murad.Api.CQRSandMediatorPattern.CQRS.Query;
using Murad.Api.CQRSandMediatorPattern.CQRS.Result;
using Murad.Api.CQRSandMediatorPattern.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Handler
{
   

    public class GetByIdStudentQueryHandler : IRequestHandler<GetByIdStudentQuery, GetByIdStudentQueryResult>
    {
        private readonly StudentContext _context;

        public GetByIdStudentQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<GetByIdStudentQueryResult> Handle(GetByIdStudentQuery request, CancellationToken cancellationToken)
        {
           var entityData = await  _context.Set<Student>().FindAsync(request.Id);
            return new GetByIdStudentQueryResult
            {
                Name = entityData.Name,
                Surname = entityData.Surname,
                Age = entityData.Age,
                Group = entityData.Group,
            };
        }
    }
}
