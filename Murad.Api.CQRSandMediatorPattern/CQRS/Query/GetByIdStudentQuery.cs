using MediatR;
using Murad.Api.CQRSandMediatorPattern.CQRS.Result;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Query
{
    public class GetByIdStudentQuery:IRequest<GetByIdStudentQueryResult>
    {
        public int Id { get; set; }

        public GetByIdStudentQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
