using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVCBasica.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(200, ErrorMessage = "O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(50, ErrorMessage = "O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(8, ErrorMessage = "O campos {0} precidade ter {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(100, ErrorMessage = "O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(100, ErrorMessage = "O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Campos {0} é Obrigadorio")]
        [StringLength(50, ErrorMessage = "O campos {0} precidade ter entre{2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        /*EF Retations*/
        public Fornecedor Fornecedor { get; set; }
    }
}
