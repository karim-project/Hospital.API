using Hospital.core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Departments.Commands.Models
{
    public class DeleteDepartmentCommand :IRequest<Response<string>>
    {
        public Guid Id { get; set; }
        public DeleteDepartmentCommand(Guid id)
        {
        Id = id;
        }
    }
}
