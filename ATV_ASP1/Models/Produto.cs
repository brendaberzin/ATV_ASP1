using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATV_ASP1.Models
{
    public class Produto
    {
        [Required(ErrorMessage="Campo Obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage="Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [StringLength(30, MinimumLength=5, ErrorMessage="Insira de 5 a 30 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(1.00, 99.00, ErrorMessage="Valor Inválido")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor Inválido")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(1.00, 99.00, ErrorMessage = "Valor Inválido")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage="Valor Inválido")]
        public string Valor_Unit { get; set; }
    }
}