using AutoMapper;
using Hospital.core.Features.Doctors.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Mapping.Doctors
{
    public partial class DoctorProfile 
    {
        public void AddDoctorCommandMapping()
        {
            CreateMap<CreateDoctorCommand, Doctor>()
                    .ForMember(d => d.DepartmentId, o => o.MapFrom(d => d.Department.Name))
                    .ForMember(d => d.SpecialtyId, o => o.MapFrom(d => d.Specialty!.Name));

        }
    }
}
