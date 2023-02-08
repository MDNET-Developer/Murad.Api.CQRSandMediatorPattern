using MediatR;

namespace Murad.Api.CQRSandMediatorPattern.CQRS.Command
{
    public class UpdateStudentCommand:IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
    }
}
