using SMA.Contracts;
using SMA.Contracts.Data;
using SMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Implementations
{
    public class OrcamentoRepository : IOrcamentoRepository
    {
        private readonly SMAContext context;
        public OrcamentoRepository(SMAContext context)
        {
            this.context = context;
        }
        public Orcamento Create(Orcamento orcamento)
        {
            try
            {
                context.Add(orcamento);
                context.SaveChanges();
                return orcamento;
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
                var orcamento = context.Orcamentos.Find(id);

                if (orcamento == null)
                    return;

                context.Remove(orcamento);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Orcamento GetById(int id)
        {
            try
            {
                var orcamento = context.Orcamentos.FirstOrDefault(x => x.Id == id);
                return orcamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Orcamento> PegarTodos()
        {
            try
            {
                var orcamento = context.Orcamentos.ToList();
                return orcamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Orcamento UpdateOrcamento(Orcamento orcamento)
        {
            try
            {
                var orcamentoParaUpdate = GetById(orcamento.Id);

                context.Update(orcamentoParaUpdate);
                context.SaveChanges();

                return orcamentoParaUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
