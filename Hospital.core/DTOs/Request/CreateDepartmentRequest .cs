namespace Hospital.core.DTOs.Request
{
    public class CreateDepartmentRequest
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
