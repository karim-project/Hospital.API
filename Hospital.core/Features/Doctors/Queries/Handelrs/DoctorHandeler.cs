using AutoMapper;
using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.core.Features.Doctors.Queries.Response;
using Hospital.Infrustructure.Data;
using Hospital.Service.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Queries.Handelrs
{
    public class DoctorHandler : IRequestHandler<GetDoctorQuery, List<DoctorResponse>>,
                                  IRequestHandler<GetDoctorByIDQuery,DoctorResponse>
    {
        private readonly ApplicationDBcontext _context;
        private readonly IRepositoryService<Doctor> _DoctorepositoryService;
        private readonly IMapper _mapper;

        public DoctorHandler(ApplicationDBcontext context, IRepositoryService<Doctor> DoctorrepositoryService,IMapper mapper)
        {
            _context = context;
            _DoctorepositoryService = DoctorrepositoryService;
            _mapper = mapper;
        }

        public async Task<List<DoctorResponse>> Handle(GetDoctorQuery request, CancellationToken cancellationToken)
        {
            var doctors = await _DoctorepositoryService.GetAsync(includes: [d => d.Department!, d => d.Specialty!], tracked: false, cancellationToken: cancellationToken);
            var doctorMapper = _mapper.Map<List<DoctorResponse>>(doctors);

            return doctorMapper;
        }

        public async Task<DoctorResponse> Handle(GetDoctorByIDQuery request, CancellationToken cancellationToken)
        {
            var doctor = await _DoctorepositoryService.GetOneAsync(d => d.Id == request.Id, includes: [d => d.Department!, d => d.DoctorSpecialties], cancellationToken: cancellationToken);
            if (doctor is null)
                return null;

            var result = _mapper.Map<DoctorResponse>(doctor);

            return result;
            

        }
    }
}
