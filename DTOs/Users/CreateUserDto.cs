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

        [Range(0, 500)]
        public decimal Weight { get; set; }
    }
}
