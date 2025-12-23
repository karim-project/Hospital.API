using Hospital.core.Features.Doctors.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Queries.Models
{
    public class GetDoctorByIDQuery :IRequest<DoctorResponse>
    {
        public Guid Id { get; set; }

        public GetDoctorByIDQuery(Guid id)
        {
            Id = id;
        }

    }
}
