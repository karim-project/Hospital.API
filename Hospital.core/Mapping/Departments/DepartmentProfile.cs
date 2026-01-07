using AutoMapper;
using Hospital.core.Features.Departments.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Mapping.Departments
{
    public partial class DepartmentProfile : Profile
    {
        public DepartmentProfile() 
        {
            CreateMap<Department, DepartmentResponse>();
        }
    }
}
