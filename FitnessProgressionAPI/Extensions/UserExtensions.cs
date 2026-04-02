using FitnessProgressionAPI.DTOs;
using FitnessProgressionAPI.Models;
using System.Linq.Expressions;

namespace FitnessProgressionAPI.Extensions
{
    public static class UserExtensions
    {
        public static Expression<Func<User, UserResponseDto>> ToDto()
        {
            return u => new UserResponseDto
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                DateOfBirth = u.DateOfBirth,
                Weight = u.Weight
            };
        }
    }
}
