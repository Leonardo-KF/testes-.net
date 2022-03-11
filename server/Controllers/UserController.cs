using Microsoft.AspNetCore.Mvc;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users()
        {
            return new List<User> {

                new User {
                    Id = 1,
                    Name = "Leo",
                    Date = new DateTime()
                }

          };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users());
        }

        [HttpPost]

        public IActionResult Post(User user)
        {
            var usuarios = Users();
            usuarios.Add(user);
            return Ok(usuarios);
        }

    }

}