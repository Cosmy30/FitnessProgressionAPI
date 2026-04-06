using FitnessProgressionAPI.DTOs;
using FitnessProgressionAPI.Models;

namespace FitnessProgressionAPI.Extensions
{
    public static class UserExtensions
    {
        public static void ApplyUpdate(this User user, UpdateUserDto dto)
        {
            user.Name = dto.Name ?? user.Name;
            user.Email = dto.Email ?? user.Email;
            user.DateOfBirth = dto.DateOfBirth ?? user.DateOfBirth;
            user.Weight = dto.Weight ?? user.Weight;
        }
    }
}
