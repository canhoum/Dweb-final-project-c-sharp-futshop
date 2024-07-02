namespace futshopvs2022.Models
{
    public class utilizador
    {
        public int UtilizadorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<transacao> Transacao { get; set; }
    }
}
