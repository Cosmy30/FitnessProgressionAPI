using FitnessProgressionAPI.DTOs;
using FitnessProgressionAPI.Models;

namespace FitnessProgressionAPI.Extensions
{
    public static class UserExtensions
    {
        public static UserResponseDto ToDto(this User user)
        {
            return new UserResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth,
                Weight = user.Weight
            };
        }
    }
}
