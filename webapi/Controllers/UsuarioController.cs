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
            return new List<Usuario>
        }   
        
        [HttpGet]
        public string Get()
        {
            return "ok";
        }
    }
}