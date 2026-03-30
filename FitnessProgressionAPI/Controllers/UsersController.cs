using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.Models;
using FitnessProgressionAPI.DTOs;

namespace FitnessProgressionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController (AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserResponseDto>>> GetUsers()
        {
            var result = await _context.Users
                .Select(u => new UserResponseDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    DateOfBirth = u.DateOfBirth,
                    Weight = u.Weight

                }).ToListAsync();

            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponseDto>> GetUserById(int id)
        {
            var result = await _context.Users
                .Where(u => u.Id == id)
                .Select(u => new UserResponseDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    DateOfBirth = u.DateOfBirth,
                    Weight = u.Weight

                }).FirstOrDefaultAsync();

            if (result == null)
            {
                return NotFound();
            }
            
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<UserResponseDto>> CreateUser(CreateUserDto dto)
        {
            User user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                DateOfBirth = dto.DateOfBirth,
                Weight = dto.Weight
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var result = new UserResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth,
                Weight = user.Weight
            };

            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, result);
        }

    }
}
