namespace futshopvs2022.Models
{
    public class Carrinho
    {
        public int CarrinhoId { get; set; }

        public int CompraId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public Transacao Compra { get; set; }

        public Artigos artigo { get; set; }
    }
}
