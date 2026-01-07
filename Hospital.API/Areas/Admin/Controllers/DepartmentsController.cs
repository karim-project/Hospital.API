using Hospital.core.Features.Departments.Commands.Models;
using Hospital.core.Features.Departments.Queries.Models;
using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.Data.Models;
using Hospital.Infrustructure.Data;
using Hospital.Infrustructure.Repositories.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hospital.API.Areas.Admin.Controllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Department> _doctorRepository;
        private readonly ApplicationDBcontext _context;
        private readonly ILogger<DoctorsController> _logger;

        public DepartmentsController(IMediator mediator, IRepository<Department> doctorRepository, ApplicationDBcontext context, ILogger<DoctorsController> logger)
        {
            _mediator = mediator;
            _doctorRepository = doctorRepository;
            _context = context;
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetDepartmentQuery());

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(Guid id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetDepartmentByIDQuery(id));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] AddDepartmentCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
        [HttpPut("Edit")]
        public async Task<IActionResult> Edit([FromForm] EditDepartmentCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id , CancellationToken cancellationToken)
        {
            var response =await _mediator.Send(new DeleteDepartmentCommand(id));

            return Ok(response);
        }
    
    }
}
