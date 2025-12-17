

using System.ComponentModel.DataAnnotations;

namespace Hospital.core.DTOs.Request
{
    public class ValidateOTPRequset
    {
        [Required]
        public string OTP { get; set; } = string.Empty;

        public string ApplicationUserId { get; set; } = string.Empty;
    }
}
