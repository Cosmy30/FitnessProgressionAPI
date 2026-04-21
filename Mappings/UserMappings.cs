using FitnessProgressionAPI.DTOs.Users;
using FitnessProgressionAPI.Models;
using System.Linq.Expressions;

namespace FitnessProgressionAPI.Mappings
{
    public static class UserMappings
    {
        public static Expression<Func<User, UserResponseDto>> ToDtoExpression()
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

        public static User ToUser(this CreateUserDto dto)
        {
            return new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                DateOfBirth = dto.DateOfBirth,
                Weight = dto.Weight
            };
        }
    }
}
