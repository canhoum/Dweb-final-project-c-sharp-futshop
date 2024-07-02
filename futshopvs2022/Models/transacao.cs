namespace futshopvs2022.Models
{
    public class transacao
    {
        public int CompraId { get; set; }
        public int UtilizadorId { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal Total { get; set; }
        public utilizador Utilizador { get; set; }
        public ICollection<carrinho> ItensCarrinho { get; set; }
    }
}
