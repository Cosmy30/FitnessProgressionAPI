using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.Users;
using FitnessProgressionAPI.Extensions;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<UserResponseDto>> GetAllAsync()
        {
            return _context.Users
                .Select(UserMappings.ToDtoExpression())
                .ToListAsync();
        }

        public Task<UserResponseDto?> GetByIdAsync(int id)
        {
            return _context.Users
                .Where(u => u.Id == id)
                .Select(UserMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<UserResponseDto> CreateAsync(CreateUserDto dto)
        {
            var user = dto.ToUser();
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.ToDto();
        }

        public async Task<UserResponseDto?> PatchAsync(int id, UpdateUserDto dto)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return null;
            }

            user.ApplyUpdate(dto);
            await _context.SaveChangesAsync();

            return user.ToDto();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<bool> UserExistsAsync(int id)
        {
            return _context.Users.AnyAsync(u => u.Id == id);
        }
    }
}
