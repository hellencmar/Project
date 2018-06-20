using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Funcionario : Pessoa
    {
        [Key]
        public int FuncionarioID { get; set; }
        public string Funcao { get; set; }
    }
}