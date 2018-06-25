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
            contexto.Clientes.Add(entity);
            contexto.SaveChanges();
        }
        public Cliente BuscarClientePorID(int id)
        {
            return contexto.Clientes.Find(id);
        }
        public void AlterCliente(Cliente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public List<Cliente> ListTodosClientes()
        {
            return contexto.Clientes.ToList();
        }        
        public void Excluir(int id)
        {
            Cliente c = contexto.Clientes.Find(id);

            if (c != null)
            {
                contexto.Clientes.Remove(c);
                contexto.SaveChanges();
            }
        }

    }
}