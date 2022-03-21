using UsersDto.Dto;
using Users.Models;
using Users.Services;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    [Route("auth/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            CreatePasswordHash(request.Password, out )
        }

    }
}