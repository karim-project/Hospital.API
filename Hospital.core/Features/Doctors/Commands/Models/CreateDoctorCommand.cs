using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Commands.Models
{
    public class CreateDoctorCommand :IRequest<string>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Department Department { get; set; }
        public Guid? DepartmentId { get; set; }

       public Specialty Specialty { get; set; }
        public Guid? SpecialtyId { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }

       
    }
}
