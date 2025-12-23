using AutoMapper;
using Hospital.core.Features.Doctors.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Mapping.Doctors
{
    public partial class DoctorProfile:Profile
    {
        public DoctorProfile() 
        {
            CreateMap<Doctor, DoctorResponse>()
                    .ForMember(d => d.DepartmentName, o => o.MapFrom(d => d.Department!.Name))
                    .ForMember(d => d.SpecialtyName, o => o.MapFrom(d => d.Specialty!.Name));


            AddDoctorCommandMapping();

        }
    }
}
