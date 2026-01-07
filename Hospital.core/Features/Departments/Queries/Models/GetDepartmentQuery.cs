using Hospital.core.Bases;
using Hospital.core.Features.Departments.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Departments.Queries.Models
{
    public class GetDepartmentQuery : IRequest<Response<List<DepartmentResponse>>>
    {
    }
}
