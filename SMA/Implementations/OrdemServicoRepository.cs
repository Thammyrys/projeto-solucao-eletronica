using SMA.Contracts;
using SMA.Contracts.Data;
using SMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Implementations
{
    public class OrdemServicoRepository : IOrdemServicoRepository
    {
        private readonly SMAContext context;
        public OrdemServicoRepository(SMAContext context)
        {
            this.context = context;
        }
        public OrdemServico Create(OrdemServico ordemServico)
        {
            try
            {
                context.Add(ordemServico);
                context.SaveChanges();
                return ordemServico;
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
                var ordemServico = context.OrdemServicos.Find(id);

                if (ordemServico == null)
                    return;

                context.Remove(ordemServico);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrdemServico GetById(int id)
        {
            try
            {
                var ordemServico = context.OrdemServicos.FirstOrDefault(x => x.Id == id);
                return ordemServico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<OrdemServico> PegarTodos()
        {
            try
            {
                var ordemServico = context.OrdemServicos.ToList();
                return ordemServico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrdemServico UpdateOrdemServico(OrdemServico ordemServico)
        {
            try
            {
                var ordemServicoParaUpdate = GetById(ordemServico.Id);

                context.Update(ordemServicoParaUpdate);
                context.SaveChanges();

                return ordemServicoParaUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
