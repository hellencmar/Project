using System.ComponentModel.DataAnnotations;

namespace Models
{
    public abstract class Pessoa
    {
        //[Key]
        //public int PessoaID { get; set; }
        [Required, MaxLength(50)]
        public string Nome { get; set; }
        [Required, MaxLength(10)]
        public string Telefone { get; set; }
        public bool Status { get; set; }


    }
}