using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.Services.Interfaces;
using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.Models;
using FitnessProgressionAPI.DTOs;
using FitnessProgressionAPI.Mappings;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<UserResponseDto>> GetAll()
        {
            return _context.Users.Select(UserMappings.ToDtoExpression()).ToListAsync();
        }

        public Task<UserResponseDto?> GetById(int id)
        {
            return _context.Users
                .Where(u => u.Id == id)
                .Select(UserMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<User> Create()
        {

        }

        public async Task<User> UpdatePartial(int id)
        {

        }

        public async Task<bool> Delete(int id)
        {

        }
    }
}
