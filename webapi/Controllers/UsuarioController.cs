using Microsoft.AspNetCore.Mvc;
using usuario.Models;
using webapi.Repository;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            _repository.AddUser(usuario);

            return await _repository.SaveChangesAsync() ? Ok("Usuario cadastrado com sucesso") : StatusCode(500, "Erro ao cadastrar usuario");
        }
    }
}