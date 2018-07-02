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
            contexto.Anotacoes.Add(entity);
            contexto.SaveChanges();
        }
        public Anotacao BuscarAnotacaoPorID(int id)
        {
            return contexto.Anotacoes.Find(id);
        }
        public List<Anotacao> ListAnotacoes()
        {
            return contexto.Anotacoes.ToList();
        }
        public void Excluir(int id)
        {
            Anotacao a = contexto.Anotacoes.Find(id);

            if (a != null)
            {
                contexto.Anotacoes.Remove(a);
                contexto.SaveChanges();
            }
        }
    }
}
