namespace futshopvs2022.Models
{
    public class Transacao
    {
        public int CompraId { get; set; }
        public int UtilizadorId { get; set; }

        public int NumeroCartao { get; set; }
        public int CVV {  get; set; }
        public DateTime DataCompra { get; set; }
        public decimal Total { get; set; }
        public Utilizador Utilizador { get; set; }
        public ICollection<Carrinho> ItensCarrinho { get; set; }
    }
}
