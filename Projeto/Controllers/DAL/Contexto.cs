using Models;
using System.Data.Entity;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}