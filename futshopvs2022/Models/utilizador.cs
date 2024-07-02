using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace futshopvs2022.Models
{
    public class Utilizador
    {
        public int UtilizadorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Morada { get; set; }

        //numero de telefone
        [RegularExpression(@"^9[1236]\d{7}$", ErrorMessage = "O Telefone deve começar com 9 e ter exatamente 9 dígitos")]
        public string Telefone { get; set; }

        public string ImagemUtilizador { get; set; }

        public ICollection<Transacao> Transacao { get; set; }
    }
}
