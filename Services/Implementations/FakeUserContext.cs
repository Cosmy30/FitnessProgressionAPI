using FitnessProgressionAPI.Services.Interfaces;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class FakeUserContext : IUserContext
    {
        public int UserId => 1;
    }
}
