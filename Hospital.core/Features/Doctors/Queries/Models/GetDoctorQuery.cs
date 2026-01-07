using Hospital.core.Bases;
using Hospital.core.Features.Doctors.Queries.Response;
using Hospital.Data.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Queries.Models
{
    public class GetDoctorQuery : IRequest<Response<List<DoctorResponse>>>
    {
    }
}
