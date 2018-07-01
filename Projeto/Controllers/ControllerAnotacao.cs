using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
   public class ControllerAnotacao
    {
        Contexto contexto = new Contexto();
        public void CadastrarAnotacao(Anotacao entity)
        {
            contexto.AnotacoesCont.Add(entity);
            contexto.SaveChanges();
        }
        public void AlterarAnotacao(Anotacao entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public List<Anotacao> ListAnotacoes()
        {
            return contexto.AnotacoesCont.ToList();
        }
        public void Excluir(int id)
        {
            Anotacao a = contexto.AnotacoesCont.Find(id);

            if (a != null)
            {
                contexto.AnotacoesCont.Remove(a);
                contexto.SaveChanges();
            }
        }
    }
}
