using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DDDProject.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Preencha um Email válido")]
        public bool Disponivel { get; set; }
        [ScaffoldColumn(false)]
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
