using Hospital.core.DTOs.Request;
using Hospital.core.DTOs.Response;
using Hospital.core.Features.Doctors.Commands.Models;
using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.Data.Models;
using Hospital.Infrustructure.Data;
using Hospital.Infrustructure.Repositories.IRepositories;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Hospital.API.Areas.Admin.Controllers
{
    [Route("api/[Area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    public class DoctorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorsController(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var response =await _mediator.Send(new GetDoctorQuery());

            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(Guid id,CancellationToken cancellationToken)
        {
            var response =await _mediator.Send(new GetDoctorByIDQuery(id));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateDoctorCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
