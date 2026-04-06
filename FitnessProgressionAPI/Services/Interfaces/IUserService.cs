using FitnessProgressionAPI.DTOs;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserResponseDto>> GetAll();
        public Task<UserResponseDto?> GetById(int id);
        public Task<UserResponseDto> Create(CreateUserDto dto);
        public Task<UserResponseDto?> Patch(int id, UpdateUserDto dto);
        public Task<bool> Delete(int id);

    }
}
