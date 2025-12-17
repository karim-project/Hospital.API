namespace Hospital.core.DTOs.Request
{
    public class UpdateSpecialtyRequest
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
