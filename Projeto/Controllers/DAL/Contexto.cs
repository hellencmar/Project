using Models;
using System.Data.Entity;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        //public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Anotacao> Anotacoes { get; set; }


    }
}