using AutoMapper;
using Hospital.core.Bases;
using Hospital.core.DTOs.Request;
using Hospital.core.Features.Doctors.Commands.Models;
using Hospital.Data.Models;
using Hospital.Service.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Commands.Handelrs
{
    public class DoctorHandelerCommand : ResponseHandler,
                                         IRequestHandler<AddDoctorCoomand, Response<string>>,
                                         IRequestHandler<EditDoctorCoomand, Response<string>>,
                                         IRequestHandler<DeleteDoctorCoomand, Response<string>>
    {
        private readonly IRepositoryService<Doctor> _repositoryService;
        private readonly IMapper _mapper;

        public DoctorHandelerCommand(IRepositoryService<Doctor> repositoryService , IMapper mapper)
        {
           _repositoryService = repositoryService;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(AddDoctorCoomand request, CancellationToken cancellationToken)
        {
            var doctorMapper = _mapper.Map<Doctor>(request);

            if (request.Img is not null && request.Img.Length > 0)
            {
                var fillName = Guid.NewGuid().ToString() + Path.GetExtension(request.Img.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\DoctorImg", fillName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await request.Img.CopyToAsync(stream);
                }
                //save img
                doctorMapper.Img = fillName;
            }

            var result =await _repositoryService.AddAsync(doctorMapper);
           await _repositoryService.CommitAsync();

            if (result is null)
                return new Response<string>("exit");
            else if (result is not null)
                return Created("Add succfully");

            return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditDoctorCoomand request, CancellationToken cancellationToken)
        {
            var doctor =await _repositoryService.GetOneAsync(d=>d.Id == request.Id);

            if (doctor is null) return NotFound<string>("Doctor is not found");

            _mapper.Map(request, doctor);

            _repositoryService.Update(doctor);

           await _repositoryService.CommitAsync(cancellationToken);

            return Success("Doctor updated successfully");

        }

        public async Task<Response<string>> Handle(DeleteDoctorCoomand request, CancellationToken cancellationToken)
        {
            var doctor = await _repositoryService.GetOneAsync(d => d.Id == request.Id);

            if (doctor is null) return NotFound<string>("Doctor is not found");

            // remove old photo
            var oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\DoctorImg", doctor.Img!);
            if (System.IO.File.Exists(oldPath))
            {
                System.IO.File.Delete(oldPath);
            }

            _repositoryService.Delete(doctor);
           await _repositoryService.CommitAsync(cancellationToken);

            return Success("Doctor Delete successfully");
        }
    }
}
