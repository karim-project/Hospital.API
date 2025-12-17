namespace Hospital.core.DTOs.Response
{
    public class SpecialtyResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
