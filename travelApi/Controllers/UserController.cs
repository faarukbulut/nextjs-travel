using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using travelApi.Dtos.UserDtos;
using travelApi.Repositories.UserRepositories;

namespace travelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserList()
        {
            var values = await _userRepository.GetUserListAsync();
            return Ok(values);
        }
        
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            await _userRepository.CreateUserAsync(createUserDto);
            return Ok("OK");
        }
    }
}
