using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ControllerFuncionario
    {
        private Contexto contexto = new Contexto();
        public void CadastrarFuncionario(Funcionario entity)
        {
            entity.Status = true;
            contexto.Funcionario.Add(entity);
            contexto.SaveChanges();
        }
        public void AlterFuncionario(Funcionario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public List<Funcionario> ListTodosFuncionario()
        {
            return contexto.Funcionario.ToList();
        }
        public List<Funcionario> ListFuncionariosAtivos()
        {
            return contexto.Funcionario.Where(c => c.Status == true).ToList();
        }
        public List<Funcionario> ListarPorFuncao(string funcao)
        {
            return contexto.Funcionario.Where(f => f.Funcao.ToLower() == funcao.ToLower()).ToList();
        }
        public void Excluir(int id)
        {
            Funcionario f = contexto.Funcionario.Find(id);

            if (f != null)
            {
                contexto.Funcionario.Remove(f);
                contexto.SaveChanges();
            }
        }
    }
}