using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Funcionario : Pessoa
    {
        //[Key]
        //public int FuncionarioID { get; set; }
        public string Funcao { get; set; }
        public int CodFun { get; private set; }
        public void SetCodFun()
        {
            CodFun = 2;
        }
    }
} 