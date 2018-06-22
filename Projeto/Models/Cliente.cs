
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente : Pessoa
    {
        //[Key]
        //public int ClienteID { get; set; }
        [Required, MaxLength(11)]
        public string CPF { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public int CodCli { get; private set; }
        private void SetCodCli()
        {
            CodCli = 1;
        }


    }

}