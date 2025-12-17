using System.Text.Json.Serialization;

namespace Hospital.core.DTOs.Request
{
    public class UpdateAdmissionRequest
    {
        public Guid PatientId { get; set; }
        [JsonIgnore]
        public Patient Patient { get; set; } = default!;
        public DateTime AdmitAt { get; set; }
        public DateTime? DischargeAt { get; set; }
        public Guid RoomId { get; set; }
        public Guid BedId { get; set; }


        public List<Visit>? Visits { get; set; }
    }
}
