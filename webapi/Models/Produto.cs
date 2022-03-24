namespace webapi.Models
{
    // crie uma classe publica de um produto que terá nome, descricao, preço e quantidade
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }

}