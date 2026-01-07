using Hospital.core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Departments.Commands.Models
{
    public class AddDepartmentCommand : IRequest<Response<string>>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
