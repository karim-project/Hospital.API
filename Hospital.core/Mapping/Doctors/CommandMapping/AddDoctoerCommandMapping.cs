using Hospital.core.DTOs.Response;
using Hospital.core.Features.Doctors.Commands.Models;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Mapping.Doctors.CommandMapping
{
    public partial class AddDoctoerCommandMapping : Profile
    {
        public AddDoctoerCommandMapping()
        {
            CreateMap<AddDoctorCoomand, Doctor>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.Department, o => o.Ignore())
                .ForMember(d => d.Specialty, o => o.Ignore());
        }
    }
}
