using SMA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Contracts
{
    public interface IOrcamentoRepository
    {
        IEnumerable<Orcamento> PegarTodos();
        Orcamento GetById(int id);
        Orcamento UpdateOrcamento(Orcamento orcamento);
        void DeleteById(int id);
        Orcamento Create(Orcamento orcamento);
    }
}
