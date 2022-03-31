using SMA.Contracts;
using SMA.Contracts.Data;
using SMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Implementations
{
    public class TecnicoRepository : ITecnicoRepository
    {
        private readonly SMAContext context;
        public TecnicoRepository(SMAContext context)
        {
            this.context = context;
        }
        public Tecnico Create(Tecnico tecnico)
        {
            try
            {
                context.Add(tecnico);
                context.SaveChanges();
                return tecnico;
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
                var tecnico = context.Tecnicos.Find(id);

                if (tecnico == null)
                    return;

                context.Remove(tecnico);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tecnico GetById(int id)
        {
            try
            {
                var tecnico = context.Tecnicos.FirstOrDefault(x => x.Id == id);
                return tecnico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Tecnico> PegarTodos()
        {
            try
            {
                var tecnico = context.Tecnicos.ToList();
                return tecnico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tecnico UpdateTecnico(Tecnico tecnico)
        {
            try
            {
                var tecnicoParaUpdate = GetById(tecnico.Id);

                context.Update(tecnicoParaUpdate);
                context.SaveChanges();

                return tecnicoParaUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
