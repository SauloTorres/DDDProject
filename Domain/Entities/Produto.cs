using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Display(Name = "Produto")]
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        [Display(Name="Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
