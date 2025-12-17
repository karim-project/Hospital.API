using System.ComponentModel.DataAnnotations;

namespace Hospital.core.DTOs.Request
{
    public class ResendComfirmEmailRequset
    {
        [Required]
        public string UserNameOrEmail { get; set; } = string.Empty;
    }
}
