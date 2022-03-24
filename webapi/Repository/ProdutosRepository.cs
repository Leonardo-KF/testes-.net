using webapi.Models;
using webapi.Data;
using Microsoft.EntityFrameworkCore;

namespace webapi.Repository
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly ProdutoContext _context;

        public ProdutosRepository(ProdutoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> FindProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> FindProdutos(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void AddProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void UpdateProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
        }

        public void DeleteProduto(int id)
        {
            _context.Produtos.Remove(new Produto { Id = id });
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}