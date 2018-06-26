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
            contexto.Funcionarios.Add(entity);
            contexto.SaveChanges();
        }
        public void AlterFuncionario(Funcionario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public Funcionario BuscarFuncionarioPorID(int id)
        {
            return contexto.Funcionarios.Find(id);
        }
        public List<Funcionario> ListTodosFuncionarios()
        {
            return contexto.Funcionarios.ToList();
        }
        public List<Funcionario> ListarPorFuncao(string funcao)
        {
            return contexto.Funcionarios.Where(f => f.Funcao.ToLower() == funcao.ToLower()).ToList();
        }
        public void Excluir(int id)
        {
            Funcionario f = contexto.Funcionarios.Find(id);

            if (f != null)
            {
                contexto.Funcionarios.Remove(f);
                contexto.SaveChanges();
            }
        }
    }
}