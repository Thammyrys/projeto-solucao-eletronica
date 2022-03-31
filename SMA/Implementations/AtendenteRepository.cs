using SMA.Contracts;
using SMA.Contracts.Data;
using SMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Implementations
{
    public class AtendenteRepository : IAtendenteRepository
    {
        private readonly SMAContext context;
        public AtendenteRepository(SMAContext context)
        {
            this.context = context;
        }
        public Atendente Create(Atendente atendente)
        {
            try
            {
                context.Add(atendente);
                context.SaveChanges();
                return atendente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                var atendente = context.Atendentes.Find(id);

                if (atendente == null)
                    return;

                context.Remove(atendente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Atendente GetById(int id)
        {
            try
            {
                var atendente = context.Atendentes.FirstOrDefault(x => x.Id == id);
                return atendente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Atendente> PegarTodos()
        {
            try
            {
                var atendente = context.Atendentes.ToList();
                return atendente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Atendente UpdateAtendente(Atendente atendente)
        {
            try
            {
                var atendenteParaUpdate = GetById(atendente.Id);

                context.Update(atendenteParaUpdate);
                context.SaveChanges();

                return atendenteParaUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
