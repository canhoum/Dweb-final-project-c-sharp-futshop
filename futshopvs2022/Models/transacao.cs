using System.ComponentModel.DataAnnotations;

namespace futshopvs2022.Models
{
    public class Transacao
    {
        public int CompraId { get; set; }
        public int UtilizadorId { get; set; }


        //nuemro do cartao
        [RegularExpression(@"^\d{16}$", ErrorMessage = "O número do cartão deve ter exatamente 16 dígitos")]
        [Required(ErrorMessage = "Número do cartão é obrigatório")]
        public string NumeroCartao { get; set; }


        //CVV do cartao
        [RegularExpression(@"^\d{3}$", ErrorMessage = "O CVV deve ter exatamente 3 dígitos")]
        [Required(ErrorMessage = "CVV é obrigatório")]
        public string CVV { get; set; }


        //data de validade de cartao
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-yy}", ApplyFormatInEditMode = true)]
        public DateTime ValidadeCartao { get; set; }


        public DateTime DataCompra { get; set; }

        public decimal Total { get; set; }
        public Utilizador Utilizador { get; set; }
        public ICollection<Carrinho> ItensCarrinho { get; set; }
    }
}
