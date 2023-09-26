using System.ComponentModel.DataAnnotations;

namespace UnifaatTrabalhoDjalma4.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}