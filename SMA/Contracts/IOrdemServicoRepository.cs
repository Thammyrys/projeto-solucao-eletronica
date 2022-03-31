using SMA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Contracts
{
    public interface IOrdemServicoRepository 
    {
        IEnumerable<OrdemServico> PegarTodos();
        OrdemServico GetById(int id);
        OrdemServico UpdateOrdemServico(OrdemServico ordemServico);
        void DeleteById(int id);
        OrdemServico Create(OrdemServico ordemServico);
    }
}
