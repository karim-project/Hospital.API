using System.ComponentModel.DataAnnotations;

namespace Hospital.core.DTOs.Request
{
    public class NewPasswordRequset
    {
        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required, DataType(DataType.Password)]
        public string ComfirmPassword { get; set; } = string.Empty;

        public string ApplicationUserId { get; set; } = string.Empty;
    }
}
