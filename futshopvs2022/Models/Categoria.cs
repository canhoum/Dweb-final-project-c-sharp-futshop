namespace futshopvs2022.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public ICollection<Artigos> Artigos { get; set; }
    
}
}
