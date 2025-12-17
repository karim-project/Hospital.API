using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Data.Models;
using MediatR;

namespace Hospital.core.Features.Doctors.Queries.Models
{
    public class GetDoctorQuery : IRequest<List<Doctor>>
    {
    }
}
