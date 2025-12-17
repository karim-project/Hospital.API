using Microsoft.AspNetCore.Http;

namespace Hospital.core.DTOs.Request
{
    public class UpdateDoctorRequest
    {
        public string EmployeeNumber { get; set; } = default!;
        public string FullName { get; set; } = default!;

        public string? Phone { get; set; }
        public string? Email { get; set; }
        public IFormFile? Img { get; set; }
        public Guid? DepartmentId { get; set; }

        


    }
}
