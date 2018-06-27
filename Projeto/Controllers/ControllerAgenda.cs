using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ControllerAgenda
    {
        private Contexto contexto = new Contexto();
        
        public void MarcarHorario(Agenda entity)
        {
            contexto.Agendas.Add(entity);
            contexto.SaveChanges();
        }
        public Agenda BuscarHorarioCliOrFun(int id)
        {
            return contexto.Agendas.Find(id);
        }
        public void AlterarHorario(Agenda entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges(); 
        }
        public List<Agenda> ListTodosHorariosMarcados()
        {
            return contexto.Agendas.ToList();
        }
        //public List<Agenda> ListarPorNomeFun(int id)
        //{        
        //}
        public void Excluir(int id)
        {
           Agenda agenda = contexto.Agendas.Find(id);

            if (agenda != null)
            {
                contexto.Agendas.Remove(agenda);
                contexto.SaveChanges();
            }
        }


    }
}
