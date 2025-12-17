using Hospital.core.DTOs.Response;
using Hospital.core.Features.Doctors.Queries.Models;
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
    public class DoctorHandeler : IRequestHandler<GetDoctorQuery, IEnumerable<Doctor>>
    {
        private readonly ApplicationDBcontext _context;
        private readonly IRepositoryService<Doctor> _DoctorepositoryService;

        public DoctorHandeler(ApplicationDBcontext context, IRepositoryService<Doctor> DoctorrepositoryService)
        {
            _context = context;
            _DoctorepositoryService = DoctorrepositoryService;
        }

        public async Task<IEnumerable<Doctor>> Handle(GetDoctorQuery request, CancellationToken cancellationToken)
        {
            var doctors = await _DoctorepositoryService.GetAsync(
                 includes: [
                     d => d.Department!,d=>d.Specialty!
                 ],
                 tracked: false,
                 cancellationToken: cancellationToken
             );

            var response = doctors.Select(d => new DoctorResponse
            {
                Id = d!.Id,
                FullName = d!.FullName,
                Email = d!.Email,
                Phone = d!.Phone,
                Img = d.Img,

                DepartmentId = d.DepartmentId,
                DepartmentName = d.Department!.Name,

                Specialties = d.DoctorSpecialties.Select(s => new DoctorSpecialtyResponse
                {
                    Id = s.SpecialtyId,
                    Name = s.Specialty!.Name
                }).ToList()
            });

            return (IEnumerable<Doctor>)response;
        }
    }
}
