using MediatR;
using Microsoft.EntityFrameworkCore;
using Murad.Api.CQRSandMediatorPattern.CQRS.Query;
using Murad.Api.CQRSandMediatorPattern.CQRS.Result;
using Murad.Api.CQRSandMediatorPattern.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Handler
{
    public class GetAllStudentQueryHandler :IRequestHandler<GetAllStudentQuery, IEnumerable<GetAllStudentQueryResult>>
    {
        private readonly StudentContext _context;

        public GetAllStudentQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetAllStudentQueryResult>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var allStudent = await _context.Set<Student>().Select(x => new GetAllStudentQueryResult { Name = x.Name, Surname = x.Surname, Age = x.Age, Group = x.Group }).AsNoTracking().ToListAsync();

            return allStudent;
        }
    }
}
