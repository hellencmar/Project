using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ControllerCliente
    {
        private Contexto contexto = new Contexto();

        public void CadastrarCliente(Cliente entity)
        {
            entity.Status = true;
            contexto.Cliente.Add(entity);
            contexto.SaveChanges();
        }
        public void AlterCliente(Cliente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public List<Cliente> ListTodosClientes()
        {
            return contexto.Cliente.Where(c => c.CodCli==1).ToList();
        }
        public List<Cliente> ListClientesAtivos()
        {
            return contexto.Cliente.Where(c => c.Status == true && c.CodCli==1).ToList();
        }
        public void Excluir(int id)
        {
            Cliente c = contexto.Cliente.Find(id);

            if (c != null)
            {
                contexto.Cliente.Remove(c);
                contexto.SaveChanges();
            }
        }

    }
}