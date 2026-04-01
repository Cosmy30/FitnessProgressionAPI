using FitnessProgressionAPI.Services.Interfaces;
using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.Models;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAll()
        {

        }

        public async Task<User> GetById(int id)
        {
            
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
