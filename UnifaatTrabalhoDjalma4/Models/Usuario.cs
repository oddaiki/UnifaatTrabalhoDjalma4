using System.ComponentModel.DataAnnotations;
using UnifaatTrabalhoDjalma4.Models;

namespace UnifaatTrabalhoDjalma4.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo UserName obrigatório")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo UserPass obrigatório")]
        [Display(Name = "UserPass")]
        public string UserPass { get; set; }

        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Celular obrigatório")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        public List<Cliente> Clientes { get; set; }
    }

}