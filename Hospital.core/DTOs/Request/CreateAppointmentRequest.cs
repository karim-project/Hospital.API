namespace Hospital.core.DTOs.Request
{
    public class CreateAppointmentRequest
    {
        public Guid DoctorId { get; set; }

        public Guid PatientId { get; set; }

        public DateTime Date { get; set; }

        public string? Notes { get; set; }
    }
}
