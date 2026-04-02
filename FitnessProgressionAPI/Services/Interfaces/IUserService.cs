using FitnessProgressionAPI.Models;
using FitnessProgressionAPI.DTOs;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserResponseDto>> GetAll();
        public Task<User> GetById(int id);
        public Task<User> Create();
        public Task<User> UpdatePartial(int id);
        public Task<bool> Delete(int id);

    }
}
