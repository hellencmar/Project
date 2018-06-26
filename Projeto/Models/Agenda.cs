using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Agenda
    {
        [Key]
        public int HorarioID { get; set; }
        [Required]
        public DateTime Horario { get; set; }
        [Required]
        public int FuncionarioID { get; set; }
        [Required]
        public int ClienteID { get; set; }
    }
}
