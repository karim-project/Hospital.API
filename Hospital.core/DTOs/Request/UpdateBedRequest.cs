namespace Hospital.core.DTOs.Request
{
    public class UpdateBedRequest
    {
        public string BedNumber { get; set; } = default!;
        public Guid RoomId { get; set; }
        public bool IsOccupied { get; set; }
    }
}
