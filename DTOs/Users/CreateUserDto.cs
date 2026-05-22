using System.ComponentModel.DataAnnotations;

namespace FitnessProgressionAPI.DTOs.Users
{
    public class CreateUserDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        [Range(typeof(decimal), "0.01", "500.00")]
        public decimal Weight { get; set; }
    }
}
