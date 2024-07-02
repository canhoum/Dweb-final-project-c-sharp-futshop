using System.ComponentModel.DataAnnotations;

namespace futshopvs2022.Models
{
    public class Artigos
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }


        //tamanho 
        [RegularExpression(@"^(S|M|L|XL)$", ErrorMessage = "O Tamanho deve ser S, M, L ou XL")]
        public string Tamanho { get; set; }


        public string ImagemURL { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
