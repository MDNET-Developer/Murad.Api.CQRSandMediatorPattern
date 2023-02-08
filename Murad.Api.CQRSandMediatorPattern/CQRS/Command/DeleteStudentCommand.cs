using MediatR;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Command
{
    public class DeleteStudentCommand:IRequest
    {
        public int Id { get; set; }

        public DeleteStudentCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
