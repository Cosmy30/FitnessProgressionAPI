using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.DTOs;
using FitnessProgressionAPI.Services.Interfaces;

namespace FitnessProgressionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserResponseDto>>> GetUsers()
        {
            var result = await _userService.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponseDto>> GetUserById(int id)
        {
            var result = await _userService.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<UserResponseDto>> CreateUser(CreateUserDto dto)
        {
            var result = await _userService.Create(dto);
            
            return CreatedAtAction(nameof(GetUserById), new { id = result.Id }, result);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<UserResponseDto>> PatchUser(int id, UpdateUserDto dto)
        {
            var result = await _userService.Patch(id, dto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userService.DeleteById(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
