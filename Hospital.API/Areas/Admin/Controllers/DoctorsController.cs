using Hospital.core.DTOs.Response;
using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.Data.Models;
using Hospital.Infrustructure.Data;
using Hospital.Infrustructure.Repositories.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var response =await _mediator.Send(new GetDoctorQuery());

            return Ok(response);
        }
    }
}
