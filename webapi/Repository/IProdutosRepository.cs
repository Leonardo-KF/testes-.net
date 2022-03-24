using webapi.Models;


namespace webapi.Repository
{
    public interface IProdutosRepository
    {
        Task<IEnumerable<Produto>> FindProdutos();
        Task<Produto> FindProdutos(int id);
        void AddProduto(Produto produto);
        void UpdateProduto(Produto produto);
        void DeleteProduto(int id);
        Task<bool> SaveChangesAsync();
    }
}
