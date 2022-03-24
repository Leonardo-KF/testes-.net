using webapi.Models;
using webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutosRepository _repository;

        public ProdutoController(IProdutosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            _repository.AddProduto(produto);

            return await _repository.SaveChangesAsync() ? Ok("Produto cadastrado com sucesso") : StatusCode(500, "Erro ao cadastrar produto");
        }

        // adcione a função para atualizar um produto
        [HttpPut]
        public async Task<IActionResult> Put(Produto produto)
        {
            _repository.UpdateProduto(produto);

            return await _repository.SaveChangesAsync() ? Ok("Produto atualizado com sucesso") : StatusCode(500, "Erro ao atualizar produto");
        }

        // adcione a função para deletar um produto
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _repository.DeleteProduto(id);

            return await _repository.SaveChangesAsync() ? Ok("Produto deletado com sucesso") : StatusCode(500, "Erro ao deletar produto");
        }
    }
}