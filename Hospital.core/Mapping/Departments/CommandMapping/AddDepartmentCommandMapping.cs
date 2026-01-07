using AutoMapper;
using Hospital.core.Features.Departments.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Mapping.Departments.CommandMapping
{
    public partial class AddDepartmentCommandMapping : Profile
    {
        public AddDepartmentCommandMapping() 
        {
            CreateMap<AddDepartmentCommand, Department>()
                .ForMember(d => d.Id, opt => opt.Ignore())
                .ForMember(d => d.Doctors, opt => opt.Ignore());
        }
    }
}
