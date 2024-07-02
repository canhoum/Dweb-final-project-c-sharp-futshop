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
        public string Telefone { get; set; }

        public string ImagemUtilizador { get; set; }

        public ICollection<Transacao> Transacao { get; set; }
    }
}
