using Hospital.core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Commands.Models
{
    public class AddDoctorCoomand : IRequest<Response<string>>
    {
        [Required]
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public IFormFile? Img { get; set; }

        // Department
        public Guid? DepartmentId { get; set; }
        public Guid? SpecialtyId { get; set; }
    }
}
