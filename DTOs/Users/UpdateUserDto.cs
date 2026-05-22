using System.ComponentModel.DataAnnotations;

namespace FitnessProgressionAPI.DTOs.Users
{
    public class UpdateUserDto
    {
        [StringLength(100)]
        public string? Name { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 6)]
        public string? Password { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Range(typeof(decimal), "0.01", "500.00")]
        public decimal? Weight { get; set; }
    }
}
