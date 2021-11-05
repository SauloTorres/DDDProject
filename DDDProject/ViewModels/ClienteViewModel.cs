using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DDDProject.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobreome { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Preencha um Email válido")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
