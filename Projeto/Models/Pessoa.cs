using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaID { get; set; }
        [Required, MaxLength(50)]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Status { get; set; }


    }
}