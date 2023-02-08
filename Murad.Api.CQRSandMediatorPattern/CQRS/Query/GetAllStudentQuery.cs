using MediatR;
using Murad.Api.CQRSandMediatorPattern.CQRS.Result;
using System.Collections;
using System.Collections.Generic;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Query
{
    public class GetAllStudentQuery:IRequest<IEnumerable<GetAllStudentQueryResult>>
    {
    }
}
