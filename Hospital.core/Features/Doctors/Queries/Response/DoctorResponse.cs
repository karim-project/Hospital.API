using Hospital.core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Queries.Response
{
    public class DoctorResponse
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Img { get; set; }

        // Department
        public string? DepartmentName { get; set; }
        public string? SpecialtyName { get; set; }

    }
}
