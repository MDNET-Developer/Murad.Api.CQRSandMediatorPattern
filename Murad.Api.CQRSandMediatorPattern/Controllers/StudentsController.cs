using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Murad.Api.CQRSandMediatorPattern.CQRS.Command;
using Murad.Api.CQRSandMediatorPattern.CQRS.Query;
using System.Threading.Tasks;

namespace Murad.Api.CQRSandMediatorPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(UpdateStudentCommand update)
        {
            await _mediator.Send(update);
            return Ok(update.Name + " adlı şagird uğurla yeniləndi");
        }


        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentCommand create)
        {
            await _mediator.Send(create);
            return Ok(create.Name + " adlı şagird uğurla əlavə olundu");
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var getId = await _mediator.Send(new GetByIdStudentQuery(id));
            return Ok(getId);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var getAll = await _mediator.Send(new GetAllStudentQuery());
            return Ok(getAll);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetudent(int id)
        {

            if (id != null)
            {
                var getAll = await _mediator.Send(new DeleteStudentCommand(id));
                return Ok($"ID={id} olan verilən uğurla silindi");
            }
            else
            {
                return Ok($"ID={id} olan verilən tapılmadı");
            }
            
        }
    }
}
