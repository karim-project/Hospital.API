namespace Hospital.core.DTOs.Request
{
    public class CreateSpecialtyRequest
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
