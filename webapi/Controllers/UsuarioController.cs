using Microsoft.AspNetCore.Mvc;
using usuario.Models;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> usuarios()
        {
            return new List<Usuario>{
                new Usuario{
                    Id = 0,
                    Name = "Leo",
                    Password = "qwer1234",
                }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(usuarios());
        }


        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var users = usuarios();
            users.Add(usuario);
            return Ok(users);
        }
    }
}