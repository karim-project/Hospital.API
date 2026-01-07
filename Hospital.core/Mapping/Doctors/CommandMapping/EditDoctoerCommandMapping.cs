using AutoMapper;
using Hospital.core.Features.Doctors.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Mapping.Doctors.CommandMapping
{
    public partial class EditDoctoerCommandMapping : Profile
    {
        public EditDoctoerCommandMapping() 
        {
            CreateMap<EditDoctorCoomand, Doctor>()
                   .ForMember(d => d.Id, o => o.Ignore())
                   .ForMember(d => d.Department, o => o.Ignore())
                   .ForMember(d => d.Specialty, o => o.Ignore());
        }
        
    }
}
