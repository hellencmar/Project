
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente : Pessoa
    {
        [Key]
        public int ClienteID { get; set; }
        [Required, MaxLength(11)]
        public string CPF { get; set; }
        public string Email { get; set; }3        

    }
}