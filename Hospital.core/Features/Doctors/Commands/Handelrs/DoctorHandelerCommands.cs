using AutoMapper;
using Hospital.core.Features.Doctors.Commands.Models;
using Hospital.Service.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Commands.Handelrs
{
    public class DoctorHandelerCommands : IRequestHandler<CreateDoctorCommand, string>
    {
        private readonly Service.Abstract.IRepositoryService<Doctor> _repositoryService;
        private readonly IMapper _mapper;

        public DoctorHandelerCommands(IRepositoryService<Doctor> repositoryService , IMapper mapper)
        {
            _repositoryService = repositoryService;
            _mapper = mapper;
        }

        public async Task<string> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            var doctorMapper = _mapper.Map<Doctor>(request);

            var result =await _repositoryService.AddAsync(doctorMapper);

            if (result is null)
                return "Failed to create doctor";

            return "Doctor created successfully";

        }
    }
}
