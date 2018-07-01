using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Anotacao
    {
        [Key]
        public int AnotacaoID { get; set; }
        [Required]
        public string Assunto { get; set; }
        [Required]
        public string Descricao { get; set; }
        public DateTime DataAnotacao { get; set; }
    }
}
