using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVCBasica.Models
{
    public class Produto : Entity
    {
        public Guid ForncecedorId { get; set; }
        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(200, ErrorMessage ="O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(1000, ErrorMessage = "O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        /*EF Relation*/
        public Fornecedor Fornecedor { get; set; }
    }
}
