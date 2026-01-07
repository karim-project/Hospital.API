using Hospital.core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Commands.Models
{
    public class DeleteDoctorCoomand : IRequest<Response<string>>
    {
        public Guid Id { get; set; }

        public DeleteDoctorCoomand(Guid id)
        {
            Id = id;
        }
    }
}
