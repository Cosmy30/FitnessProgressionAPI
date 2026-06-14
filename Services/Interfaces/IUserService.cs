using FitnessProgressionAPI.DTOs.Users;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserResponseDto>> GetAllAsync();
        public Task<UserResponseDto?> GetByIdAsync(int id);
        public Task<UserResponseDto> CreateAsync(CreateUserDto dto);
        public Task<UserResponseDto?> PatchAsync(int id, UpdateUserDto dto);
        public Task<bool> DeleteAsync(int id);
        public Task<bool> UserExistsAsync(int id);
    }
}
